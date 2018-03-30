import Vue from 'vue'
import Router from 'vue-router'

import Login from '../pages/Login.vue'

import listaProdutos from '../components/lista-produtos/index.vue'
import novoProduto from '../components/novo-produto/index.vue'
import excluirProduto from '../components/excluir-produto/index.vue'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'PageLogin',
      component: Login
    },
    {
      path: '/produtos/lista',
      name: 'lista-produtos',
      component: listaProdutos
    },
    {
      path: '/produtos/novo',
      name: 'novo-produto',
      component: novoProduto
    },
    {
      path: '/produtos/excluir',
      name: 'excluir-produto',
      component: excluirProduto
    }
  ]
})
