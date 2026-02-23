<template>
  <div>
    <table>
      <thead>
        <tr>
          <th v-for="column in columns" :key="column.name">{{ column.name }}</th>
        </tr>
      </thead>
      <tbody>
        <tr>
          <td v-for="column in columns" :key="column.name">
            <span class="badge">{{ column.type }}</span>
          </td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script setup>
defineProps({
  columns: {
    type: Array,
    required: true
  }
})
</script>
