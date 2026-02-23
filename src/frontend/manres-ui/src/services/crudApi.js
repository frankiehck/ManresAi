const API_BASE = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5000/api/crud'

async function request(path, options = {}) {
  const response = await fetch(`${API_BASE}${path}`, {
    headers: {
      'Content-Type': 'application/json',
      ...(options.headers || {})
    },
    ...options
  })

  if (!response.ok) {
    const text = await response.text()
    throw new Error(text || `Request failed (${response.status})`)
  }

  if (response.status === 204) return null
  return response.json()
}

export function listRows(entity, skip = 0, take = 100) {
  return request(`/${entity}?skip=${skip}&take=${take}`)
}

export function getRow(entity, id) {
  return request(`/${entity}/${encodeURIComponent(id)}`)
}

export function createRow(entity, payload) {
  return request(`/${entity}`, {
    method: 'POST',
    body: JSON.stringify(payload)
  })
}

export function updateRow(entity, id, payload) {
  return request(`/${entity}/${encodeURIComponent(id)}`, {
    method: 'PUT',
    body: JSON.stringify(payload)
  })
}

export function deleteRow(entity, id) {
  return request(`/${entity}/${encodeURIComponent(id)}`, {
    method: 'DELETE'
  })
}
