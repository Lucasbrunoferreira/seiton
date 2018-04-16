import Vue from 'vue'
import Router from 'vue-router'
import { Login, Home } from '../screens'
import { products, clients } from '../components'

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
          path: '/clientes',
          name: 'Clientes',
          component: clients
        }
      ]
    }
  ]
})
