# Manres Migration App (Vue + .NET + SQL Server)

This repository now includes a launchable stack:

- SQL Server (Docker)
- .NET 8 API with dynamic CRUD + metadata + reports
- Vue 3 frontend with data-entry pages and reports page

## Quick start

```bash
docker compose up --build
```

Then open:

- Frontend: http://localhost:8080
- API Swagger: http://localhost:5000/swagger

## What is implemented

- Dynamic CRUD endpoints for all generated tables.
- UI pages for table browsing and data entry (create/update/delete).
- Reports page with table row counts and CSV export.
- Automatic schema apply on backend startup in docker (`sql/Manres.Schema.sql`).

## Important limitation

Exact Visual FoxPro form/report parity still requires original VFP source files (`.SCX/.SCT/.VCX/.VCT/.PRG/.FRX`).
This repo currently uses DBF metadata and generated scaffolding, so UI forms/reports are functional equivalents, not pixel-perfect clones.
