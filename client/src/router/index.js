import Vue from 'vue'
import Router from 'vue-router'

import Login from '../pages/Login.vue'
import Products from '../pages/Products.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'PageLogin',
      component: Login
    },
    {
      path: '/produtos',
      name: 'PageProducts',
      component: Products
    }
  ]
})
