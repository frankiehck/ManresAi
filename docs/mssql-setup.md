# MSSQL Setup for Manres Migration

This repository now includes a generated SQL Server schema script based on the uploaded Visual FoxPro DBF metadata.

## Files

- `sql/Manres.Schema.sql` — creates all discovered DBF-backed tables in `dbo`.
- `scripts/generate_mssql_and_csharp.py` — regenerates SQL and C# model scaffolding.
- `src/backend/Manres.Api/ManresDbContext.cs` + `src/backend/Manres.Api/Models/*.cs` — EF Core scaffold for the same tables.

## How to create tables in SQL Server

Using `sqlcmd`:

```bash
sqlcmd -S <server> -d <database> -E -i sql/Manres.Schema.sql
```

Or in SSMS:

1. Open `sql/Manres.Schema.sql`.
2. Connect to your target database.
3. Execute the script.

## Notes

- Column types are mapped from DBF field metadata.
- Primary keys are inferred from `<TABLE>_PK`/`*_PK` conventions where possible.
- Foreign keys and non-PK indexes are not fully reconstructed from DBF alone; validate against CDX/index business rules before production.
