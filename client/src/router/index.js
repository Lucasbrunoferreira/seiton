import Vue from 'vue'
import Router from 'vue-router'
import { Login, Products, Clients } from '../screens'

Vue.use(Router)

export default new Router({
  routes: [
    {path: '/', redirect: '/login'},
    {
      path: '/login',
      name: 'Login',
      component: Login
    },
    {
      path: '/produtos',
      name: 'PageProdutos',
      component: Products
    },
    {
      path: '/clientes',
      name: 'Clientes',
      component: Clients
    }
  ]
})
