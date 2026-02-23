<template>
  <div class="layout">
    <SidebarNav />
    <main class="content">
      <router-view />
    </main>
  </div>
</template>

<script setup>
import SidebarNav from './components/SidebarNav.vue'
</script>
