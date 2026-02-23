<template>
  <section>
    <h1 class="page-title">Manres Migration Dashboard</h1>
    <p class="page-subtitle">Starter Vue pages generated from Visual FoxPro data metadata.</p>

    <div class="grid">
      <div class="card">
        <h3>Total Tables</h3>
        <p style="font-size: 28px; margin: 0">{{ schema.length }}</p>
      </div>
      <div class="card">
        <h3>Total Columns</h3>
        <p style="font-size: 28px; margin: 0">{{ totalColumns }}</p>
      </div>
      <div class="card">
        <h3>Estimated Source Rows</h3>
        <p style="font-size: 28px; margin: 0">{{ totalRows.toLocaleString() }}</p>
      </div>
    </div>

    <div class="card" style="margin-top:16px">
      <h3>Next steps</h3>
      <ul>
        <li>Connect these pages to .NET API endpoints for each table/workflow.</li>
        <li>Replace metadata-grid placeholders with true CRUD data grids and forms.</li>
        <li>Map each legacy VFP workflow to dedicated Vue routes/components.</li>
      </ul>
    </div>
  </section>
</template>

<script setup>
import { computed } from 'vue'
import { schema } from '../data/schema'

const totalColumns = computed(() => schema.reduce((acc, table) => acc + table.columns.length, 0))
const totalRows = computed(() => schema.reduce((acc, table) => acc + table.records, 0))
</script>
