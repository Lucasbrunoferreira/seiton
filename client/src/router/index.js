import Vue from 'vue'
import Router from 'vue-router'

import { LoginPage } from '../pages'

Vue.use(Router)

export default new Router({
  routes: [
    { path: '/', redirect: '/login' },
    {
      path: '/login',
      name: 'LoginPage',
      component: LoginPage
    }
  ]
})
