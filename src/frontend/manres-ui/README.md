# Manres Vue UI

Vue 3 + Vite frontend for the migration project.

## Local run

```bash
cd src/frontend/manres-ui
npm install
npm run dev
```

Set optional env values in `.env`:

```env
VITE_API_BASE_URL=http://localhost:5000/api/crud
VITE_API_ROOT=http://localhost:5000/api
```

## Pages

- `/` dashboard
- `/tables` table list
- `/tables/:name` data entry + CRUD page
- `/reports` report summary + CSV export

## Regenerate metadata

```bash
python scripts/generate_vue_schema.py
```
