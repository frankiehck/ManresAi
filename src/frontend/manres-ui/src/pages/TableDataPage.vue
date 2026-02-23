<template>
  <section v-if="table">
    <h1 class="page-title">{{ table.name }}</h1>
    <p class="page-subtitle">
      {{ table.records.toLocaleString() }} legacy records • {{ table.columns.length }} columns
    </p>

    <div class="card" style="margin-bottom:12px;">
      <h3 style="margin-top:0">CRUD Data Grid</h3>
      <div class="toolbar">
        <button @click="loadRows" :disabled="loading">{{ loading ? 'Loading...' : 'Load Rows' }}</button>
        <input v-model="idToLoad" placeholder="Primary key value" />
        <button @click="loadById" :disabled="loading || !idToLoad">Find By ID</button>
        <span v-if="error" style="color:#b91c1c">{{ error }}</span>
      </div>

      <table v-if="rows.length">
        <thead>
          <tr>
            <th v-for="column in table.columns" :key="column.name">{{ column.name }}</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="(row, idx) in rows" :key="idx">
            <td v-for="column in table.columns" :key="column.name">{{ row[column.name] ?? row[toProp(column.name)] }}</td>
            <td>
              <button @click="startEdit(row)">Edit</button>
              <button @click="removeRow(row)">Delete</button>
            </td>
          </tr>
        </tbody>
      </table>
      <p v-else>No rows loaded.</p>
    </div>

    <div class="card" style="margin-bottom:12px;">
      <h3 style="margin-top:0">{{ editing ? 'Edit Row' : 'Create Row' }}</h3>
      <div class="form-grid">
        <label v-for="column in table.columns" :key="column.name" class="field">
          <span>{{ column.name }}</span>
          <input v-model="form[column.name]" :disabled="editing && column.name === primaryKey" />
        </label>
      </div>
      <div class="toolbar" style="margin-top:12px">
        <button @click="saveRow" :disabled="saving">{{ saving ? 'Saving...' : editing ? 'Update' : 'Create' }}</button>
        <button @click="resetForm">Clear</button>
      </div>
    </div>

    <div class="card">
      <h3 style="margin-top:0">Field definitions</h3>
      <DataGridMock :columns="table.columns" />
    </div>
  </section>

  <section v-else>
    <h1 class="page-title">Table not found</h1>
    <RouterLink to="/tables">Back to tables</RouterLink>
  </section>
</template>

<script setup>
import { computed, ref, watch } from 'vue'
import DataGridMock from '../components/DataGridMock.vue'
import { schema } from '../data/schema'
import { createRow, deleteRow, getRow, listRows, updateRow } from '../services/crudApi'

const props = defineProps({ name: { type: String, required: true } })
const table = computed(() => schema.find((item) => item.name === props.name))
const primaryKey = computed(() => table.value?.columns.find((c) => c.name.endsWith('_PK'))?.name || '')

const rows = ref([])
const loading = ref(false)
const saving = ref(false)
const error = ref('')
const idToLoad = ref('')
const editing = ref(false)
const editId = ref('')
const form = ref({})

watch(table, () => resetForm(), { immediate: true })

function toProp(name) {
  return name
    .toLowerCase()
    .split(/[^a-z0-9]+/)
    .filter(Boolean)
    .map((p) => p.charAt(0).toUpperCase() + p.slice(1))
    .join('')
}

function resetForm() {
  const next = {}
  for (const c of table.value?.columns || []) next[c.name] = ''
  form.value = next
  editing.value = false
  editId.value = ''
}

async function loadRows() {
  if (!table.value) return
  loading.value = true
  error.value = ''
  try {
    rows.value = await listRows(table.value.name, 0, 50)
  } catch (err) {
    error.value = err?.message || 'Failed to load rows'
  } finally {
    loading.value = false
  }
}

async function loadById() {
  if (!table.value || !idToLoad.value) return
  loading.value = true
  error.value = ''
  try {
    const row = await getRow(table.value.name, idToLoad.value)
    rows.value = row ? [row] : []
  } catch (err) {
    error.value = err?.message || 'Failed to load row'
  } finally {
    loading.value = false
  }
}

function startEdit(row) {
  const next = {}
  for (const c of table.value.columns) {
    next[c.name] = row[c.name] ?? row[toProp(c.name)] ?? ''
  }
  form.value = next
  editing.value = true
  editId.value = String(next[primaryKey.value] || '')
}

async function saveRow() {
  if (!table.value) return
  saving.value = true
  error.value = ''
  try {
    const payload = { ...form.value }
    if (editing.value) {
      await updateRow(table.value.name, editId.value, payload)
    } else {
      await createRow(table.value.name, payload)
    }
    await loadRows()
    resetForm()
  } catch (err) {
    error.value = err?.message || 'Failed to save row'
  } finally {
    saving.value = false
  }
}

async function removeRow(row) {
  if (!table.value || !primaryKey.value) return
  const id = row[primaryKey.value] ?? row[toProp(primaryKey.value)]
  if (id == null || id === '') return

  try {
    await deleteRow(table.value.name, String(id))
    await loadRows()
  } catch (err) {
    error.value = err?.message || 'Failed to delete row'
  }
}
</script>
