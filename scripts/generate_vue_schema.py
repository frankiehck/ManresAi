#!/usr/bin/env python3
from __future__ import annotations

import json
import struct
from pathlib import Path

DATA_ROOT = Path('Manres20260220/Data')
OUT = Path('src/frontend/manres-ui/src/data/schema.js')


def parse_dbf(path: Path):
    raw = path.read_bytes()
    records = struct.unpack_from('<I', raw, 4)[0]
    offset = 32
    cols = []
    while offset + 32 <= len(raw):
        if raw[offset] == 0x0D:
            break
        d = raw[offset:offset + 32]
        name = d[0:11].split(b'\x00', 1)[0].decode('latin1', errors='ignore').strip()
        cols.append(
            {
                'name': name,
                'type': chr(d[11]),
                'length': d[16],
                'decimals': d[17],
            }
        )
        offset += 32
    return {'name': path.stem.upper(), 'records': records, 'columns': cols}


def main() -> None:
    files = sorted(DATA_ROOT.glob('*.DBF')) + sorted(DATA_ROOT.glob('*.dbf'))
    seen = set()
    tables = []
    for p in files:
        key = p.stem.lower()
        if key in seen:
            continue
        seen.add(key)
        tables.append(parse_dbf(p))

    OUT.parent.mkdir(parents=True, exist_ok=True)
    OUT.write_text(f'export const schema = {json.dumps(tables, indent=2)}\n', encoding='utf-8')
    print(f'Wrote {OUT} with {len(tables)} tables')


if __name__ == '__main__':
    main()
