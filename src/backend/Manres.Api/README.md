# Manres .NET data layer scaffold

Generated files in this folder are a starting point for EF Core mapping from DBF metadata.

## Usage

1. Create a .NET Web API project in this folder.
2. Add EF Core SQL Server packages.
3. Include generated `Models/*.cs` and `ManresDbContext.cs`.
4. Execute `sql/Manres.Schema.sql` against SQL Server to create tables.

## Important

- PK/FK/indexes are best-effort inference. Validate against business rules and CDX indexes before production.
- Exact form/workflow migration still requires original VFP source (`.SCX/.VCX/.PRG`).
