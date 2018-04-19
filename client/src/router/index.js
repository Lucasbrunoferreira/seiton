import Vue from 'vue'
import Router from 'vue-router'
import { Login, Home } from '../screens'
import { products, clients, newProduct } from '../components'

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
      path: '/',
      name: 'HomePage',
      component: Home,
      children: [
        {
          path: '/produtos',
          name: 'Produtos',
          component: products
        },
        {
          path: '/produtos/novo',
          name: 'Novo Produto',
          component: newProduct
        },
        {
          path: '/clientes',
          name: 'Clientes',
          component: clients
        }
      ]
    }
  ]
})
