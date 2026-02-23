# VFP Migration Readiness (Initial Pass)

## What was uploaded

The `Manres20260220.zip` package contains executable/runtime and data artifacts:

- VFP runtime executable(s): `mr.exe`, utilities (`fixlogs.exe`, `reindex.exe`, `ZAPEVENT.EXE`).
- Data container and tables (`Data/*.DBC`, `.DCT`, `.DCX`, `.DBF`, `.CDX`, `.FPT`).
- Configuration/assets (`CONFIG.FPW`, icons).

## Important gap for exact UI/logic recreation

To reproduce forms and logic **exactly** in Vue + .NET, the following source artifacts are still needed:

- Form/class source: `.SCX/.SCT`, `.VCX/.VCT`
- Program code: `.PRG`
- Menus/reports (if used): `.MNX/.MNT`, `.FRX/.FRT`
- Build project metadata: `.PJX/.PJT`

Without these source files, we can still migrate from behavior and data model, but exact parity requires reverse-engineering from the executable.

## What is ready now

- Data inventory has been generated from DBF headers at `docs/vfp-data-inventory.md`.
- This gives immediate input for .NET entity modeling and API contract drafting.

## Next recommended step

Upload a second ZIP containing source files listed above (even partial), and prioritize one high-value workflow for first end-to-end migration.
