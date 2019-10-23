import Vue from 'vue'
import Router from 'vue-router'
// @ts-ignore
import Home from './views/Home.vue'
// @ts-ignore
import Login from './views/Login.vue'

import Vault from './views/Vault.vue' 
import Keep from './views/keeps.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'home',
      component: Home
    },
    {
      path: '/login',
      name: 'login',
      component: Login
    },
    {
      path: '/vault',
      name: 'vault',
      component: Vault
    },
    {
    path: '/keeps',
    name: 'keeps',
    component: Keep 
  },
  ]
})
