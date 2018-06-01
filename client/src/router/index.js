import Vue from 'vue'
import Router from 'vue-router'

import { LoginPage, HomePage } from '../pages'

Vue.use(Router)

export default new Router({
  routes: [
    { path: '/', redirect: '/login' },
    {
      path: '/login',
      name: 'Pagina de Login',
      component: LoginPage
    },
    {
      path: '/home',
      name: 'Pagina Inicial',
      component: HomePage
    }
  ]
})
