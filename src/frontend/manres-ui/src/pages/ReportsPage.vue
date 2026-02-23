<template>
  <section>
    <h1 class="page-title">Reports</h1>
    <p class="page-subtitle">Database summary and quick CSV exports.</p>

    <div class="toolbar">
      <button @click="load" :disabled="loading">{{ loading ? 'Loading...' : 'Refresh' }}</button>
      <span v-if="error" style="color:#b91c1c">{{ error }}</span>
    </div>

    <table v-if="rows.length">
      <thead>
        <tr>
          <th>Table</th>
          <th>Rows</th>
          <th>Columns</th>
          <th>Primary Key</th>
          <th>Export</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="row in rows" :key="row.table">
          <td>{{ row.table }}</td>
          <td>{{ row.count.toLocaleString() }}</td>
          <td>{{ row.columns }}</td>
          <td>{{ row.primaryKey.join(', ') || 'N/A' }}</td>
          <td><a :href="csvUrl(row.table)" target="_blank">CSV</a></td>
        </tr>
      </tbody>
    </table>
  </section>
</template>

<script setup>
import { ref, onMounted } from 'vue'
import { getCsvUrl, getReportSummary } from '../services/reportApi'

const rows = ref([])
const loading = ref(false)
const error = ref('')

const csvUrl = (entity) => getCsvUrl(entity, 1000)

async function load() {
  loading.value = true
  error.value = ''
  try {
    rows.value = await getReportSummary()
  } catch (err) {
    error.value = err?.message || 'Failed to load reports'
  } finally {
    loading.value = false
  }
}

onMounted(load)
</script>
