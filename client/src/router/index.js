import Vue from 'vue'
import Router from 'vue-router'

import { LoginPage, HomePage, ProductsPage, ClientsPage, ProvidersPage, ContribuitorsPage } from '../pages'

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
    },
    {
      path: '/produtos',
      name: 'Produtos',
      component: ProductsPage
    },
    {
      path: '/clientes',
      name: 'Clientes',
      component: ClientsPage
    },
    {
      path: '/fornecedores',
      name: 'Fornecedores',
      component: ProvidersPage
    },
    {
      path: '/colaboradores',
      name: 'Colaboradores',
      component: ContribuitorsPage
    }
  ]
})
