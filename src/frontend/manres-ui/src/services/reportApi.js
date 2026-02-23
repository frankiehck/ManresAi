const API_ROOT = import.meta.env.VITE_API_ROOT || 'http://localhost:5000/api'

async function request(path) {
  const response = await fetch(`${API_ROOT}${path}`)
  if (!response.ok) throw new Error(await response.text())
  return response.json()
}

export function getReportSummary() {
  return request('/reports/summary')
}

export function getTablesMetadata() {
  return request('/metadata/tables')
}

export function getCsvUrl(entity, take = 1000) {
  return `${API_ROOT}/reports/table/${encodeURIComponent(entity)}/csv?take=${take}`
}
