#!/usr/bin/env python3
from __future__ import annotations

import re
import struct
from dataclasses import dataclass
from pathlib import Path

DATA_ROOT = Path('Manres20260220/Data')
SQL_OUT = Path('sql/Manres.Schema.sql')
CS_ROOT = Path('src/backend/Manres.Api')
MODELS_DIR = CS_ROOT / 'Models'
DBCONTEXT_OUT = CS_ROOT / 'ManresDbContext.cs'
README_OUT = CS_ROOT / 'README.md'


@dataclass
class Field:
    name: str
    ftype: str
    length: int
    decimals: int


def pascal_case(name: str) -> str:
    parts = re.split(r'[^A-Za-z0-9]+', name)
    if len(parts) == 1:
        s = parts[0]
        return s[:1].upper() + s[1:].lower() if s else 'Field'
    return ''.join(p[:1].upper() + p[1:].lower() for p in parts if p)


def safe_ident(name: str) -> str:
    return f'[{name}]'


def parse_dbf(path: Path):
    raw = path.read_bytes()
    records = struct.unpack_from('<I', raw, 4)[0]
    fields: list[Field] = []
    offset = 32
    while offset + 32 <= len(raw):
        if raw[offset] == 0x0D:
            break
        desc = raw[offset:offset + 32]
        name = desc[0:11].split(b'\x00', 1)[0].decode('latin1', errors='ignore').strip()
        ftype = chr(desc[11])
        flen = desc[16]
        fdec = desc[17]
        fields.append(Field(name=name, ftype=ftype, length=flen, decimals=fdec))
        offset += 32
    return records, fields


def sql_type(f: Field) -> str:
    t = f.ftype
    if t == 'C':
        if f.length <= 0:
            return 'NVARCHAR(255)'
        if f.length > 4000:
            return 'NVARCHAR(MAX)'
        return f'NVARCHAR({f.length})'
    if t == 'N':
        if f.decimals > 0:
            precision = min(max(f.length, f.decimals + 1), 38)
            return f'DECIMAL({precision},{f.decimals})'
        if f.length <= 4:
            return 'SMALLINT'
        if f.length <= 9:
            return 'INT'
        return 'BIGINT'
    if t == 'I':
        return 'INT'
    if t == 'Y':
        return 'DECIMAL(19,4)'
    if t == 'F':
        precision = min(max(f.length, f.decimals + 1), 38)
        return f'DECIMAL({precision},{f.decimals})'
    if t == 'D':
        return 'DATE'
    if t == 'T':
        return 'DATETIME2(0)'
    if t == 'L':
        return 'BIT'
    if t == 'M':
        return 'NVARCHAR(MAX)'
    return 'NVARCHAR(MAX)'


def csharp_type(f: Field) -> str:
    t = f.ftype
    if t in {'C', 'M'}:
        return 'string?'
    if t in {'N', 'I'}:
        if t == 'N' and f.decimals > 0:
            return 'decimal?'
        if f.length <= 4:
            return 'short?'
        if f.length <= 9 or t == 'I':
            return 'int?'
        return 'long?'
    if t in {'Y', 'F'}:
        return 'decimal?'
    if t == 'D':
        return 'DateTime?'
    if t == 'T':
        return 'DateTime?'
    if t == 'L':
        return 'bool?'
    return 'string?'


def candidate_pk(fields: list[Field], table: str) -> str | None:
    names = [f.name.upper() for f in fields]
    exact = f'{table.upper()}_PK'
    if exact in names:
        return exact
    pk_fields = [n for n in names if n.endswith('_PK')]
    if len(pk_fields) == 1:
        return pk_fields[0]
    return None


def build_property_map(fields: list[Field]) -> dict[str, str]:
    mapping: dict[str, str] = {}
    used: dict[str, int] = {}
    for f in fields:
        base = pascal_case(f.name)
        count = used.get(base, 0) + 1
        used[base] = count
        prop = base if count == 1 else f'{base}{count}'
        mapping[f.name] = prop
    return mapping


def generate():
    MODELS_DIR.mkdir(parents=True, exist_ok=True)
    dbf_files = sorted(DATA_ROOT.glob('*.DBF')) + sorted(DATA_ROOT.glob('*.dbf'))
    seen = set()
    tables = []
    for p in dbf_files:
        key = p.stem.lower()
        if key in seen:
            continue
        seen.add(key)
        records, fields = parse_dbf(p)
        tables.append((p.stem.upper(), records, fields))

    lines = [
        '-- Auto-generated from Visual FoxPro DBF headers.',
        '-- Review PK/FK constraints and indexes before production use.',
        'SET ANSI_NULLS ON;',
        'SET QUOTED_IDENTIFIER ON;',
        'GO',
        '',
    ]

    for table, records, fields in tables:
        lines.append(f'-- {table}: source rows at extraction time = {records}')
        lines.append(f"IF OBJECT_ID(N'dbo.{table}', N'U') IS NULL")
        lines.append('BEGIN')
        lines.append(f'    CREATE TABLE dbo.{safe_ident(table)} (')
        col_lines = []
        for f in fields:
            col_lines.append(f'        {safe_ident(f.name)} {sql_type(f)} NULL')
        lines.append(',\n'.join(col_lines))
        lines.append('    );')
        pk = candidate_pk(fields, table)
        if pk:
            lines.append(f'    IF NOT EXISTS (SELECT 1 FROM sys.key_constraints WHERE parent_object_id = OBJECT_ID(N\'dbo.{table}\') AND [type] = \'PK\')')
            lines.append(f'        ALTER TABLE dbo.{safe_ident(table)} ADD CONSTRAINT PK_{table} PRIMARY KEY CLUSTERED ({safe_ident(pk)});')
        lines.append('END')
        lines.append('GO')
        lines.append('')

    SQL_OUT.write_text('\n'.join(lines), encoding='utf-8')

    # C# entities
    model_names = []
    for table, _records, fields in tables:
        cls = pascal_case(table)
        model_names.append((table, cls, fields))
        prop_map = build_property_map(fields)
        csl = [
            'namespace Manres.Api.Models;',
            '',
            f'public class {cls}',
            '{',
        ]
        for f in fields:
            prop = prop_map[f.name]
            csl.append(f'    public {csharp_type(f)} {prop} {{ get; set; }}')
        csl.append('}')
        (MODELS_DIR / f'{cls}.cs').write_text('\n'.join(csl) + '\n', encoding='utf-8')

    db = [
        'using Manres.Api.Models;',
        'using Microsoft.EntityFrameworkCore;',
        '',
        'namespace Manres.Api;',
        '',
        'public class ManresDbContext : DbContext',
        '{',
        '    public ManresDbContext(DbContextOptions<ManresDbContext> options) : base(options) { }',
        '',
    ]
    for table, cls, _fields in model_names:
        db.append(f'    public DbSet<{cls}> {cls} => Set<{cls}>();')
    db.extend([
        '',
        '    protected override void OnModelCreating(ModelBuilder modelBuilder)',
        '    {',
        '        base.OnModelCreating(modelBuilder);',
    ])
    for table, cls, fields in model_names:
        prop_map = build_property_map(fields)
        db.append(f'        modelBuilder.Entity<{cls}>(entity =>')
        db.append('        {')
        db.append(f'            entity.ToTable("{table}");')
        pk = candidate_pk(fields, table)
        if pk:
            db.append(f'            entity.HasKey(e => e.{prop_map[pk]});')
        for f in fields:
            prop = prop_map[f.name]
            db.append(f'            entity.Property(e => e.{prop}).HasColumnName("{f.name}");')
        db.append('        });')
        db.append('')
    db.extend(['    }', '}'])
    DBCONTEXT_OUT.write_text('\n'.join(db) + '\n', encoding='utf-8')

    README_OUT.write_text(
        '# Manres .NET data layer scaffold\n\n'
        'Generated files in this folder are a starting point for EF Core mapping from DBF metadata.\n\n'
        '## Usage\n\n'
        '1. Create a .NET Web API project in this folder.\n'
        '2. Add EF Core SQL Server packages.\n'
        '3. Include generated `Models/*.cs` and `ManresDbContext.cs`.\n'
        '4. Execute `sql/Manres.Schema.sql` against SQL Server to create tables.\n\n'
        '## Important\n\n'
        '- PK/FK/indexes are best-effort inference. Validate against business rules and CDX indexes before production.\n'
        '- Exact form/workflow migration still requires original VFP source (`.SCX/.VCX/.PRG`).\n',
        encoding='utf-8'
    )

    print(f'Generated {SQL_OUT}, {DBCONTEXT_OUT}, and {len(model_names)} model classes.')


if __name__ == '__main__':
    generate()
