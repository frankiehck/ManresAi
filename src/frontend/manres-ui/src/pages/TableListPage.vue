<template>
  <section>
    <h1 class="page-title">Tables</h1>
    <p class="page-subtitle">Browse generated pages for each migrated table.</p>

    <div class="toolbar">
      <input v-model="search" placeholder="Search table..." />
      <select v-model="sort">
        <option value="name">Sort: Name</option>
        <option value="records">Sort: Records</option>
        <option value="columns">Sort: Columns</option>
      </select>
    </div>

    <div class="grid">
      <RouterLink
        v-for="table in filteredTables"
        :key="table.name"
        :to="`/tables/${table.name}`"
        class="card"
        style="text-decoration:none;color:inherit"
      >
        <h3 style="margin-top:0">{{ table.name }}</h3>
        <p><strong>{{ table.columns.length }}</strong> columns</p>
        <p><strong>{{ table.records.toLocaleString() }}</strong> rows</p>
      </RouterLink>
    </div>
  </section>
</template>

<script setup>
import { computed, ref } from 'vue'
import { schema } from '../data/schema'

const search = ref('')
const sort = ref('name')

const filteredTables = computed(() => {
  const q = search.value.toLowerCase()
  const list = schema.filter((t) => t.name.toLowerCase().includes(q))

  if (sort.value === 'records') return [...list].sort((a, b) => b.records - a.records)
  if (sort.value === 'columns') return [...list].sort((a, b) => b.columns.length - a.columns.length)
  return [...list].sort((a, b) => a.name.localeCompare(b.name))
})
</script>
