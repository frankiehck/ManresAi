import { createRouter, createWebHistory } from 'vue-router'
import HomePage from '../pages/HomePage.vue'
import TableListPage from '../pages/TableListPage.vue'
import TableDataPage from '../pages/TableDataPage.vue'
import ReportsPage from '../pages/ReportsPage.vue'
import NotFoundPage from '../pages/NotFoundPage.vue'

const routes = [
  { path: '/', component: HomePage },
  { path: '/tables', component: TableListPage },
  { path: '/tables/:name', component: TableDataPage, props: true },
  { path: '/reports', component: ReportsPage },
  { path: '/:pathMatch(.*)*', component: NotFoundPage }
]

export default createRouter({
  history: createWebHistory(),
  routes
})
