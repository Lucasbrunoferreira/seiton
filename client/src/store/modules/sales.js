export const ADD_SALE = 'ADD_SALE'
export const REMOVE_SALE_PRODUCT = 'REMOVE_SALE_PRODUCT'
export const ADD_SALE_PRODUCT = 'ADD_SALE_PRODUCT'
export const CLEAR_SALE = 'CLEAR_SALE'

const state = {
  sale: {}
}

const getters = {
  getterSale: (state) => state.sale.products
}

const mutations = {
  [ADD_SALE] (state, sale) {
    state.sale = sale
  },
  [ADD_SALE_PRODUCT] (state, product) {
    state.sale.products = state.sale.products.concat(product)
  },
  [REMOVE_SALE_PRODUCT] (state, idSale) {
    let i = state.sale.products.map(item => item.idSale).indexOf(idSale)
    state.sale.products.splice(i, 1)
  },
  [CLEAR_SALE] (state, sale) {
    state.sale.products = {}
  }
}

export default {
  state,
  getters,
  mutations
}
