import productsApi from '../../api/products.Api'

export const GET_ALL_PRODUCTS = 'GET_ALL_PRODUCTS'
export const DELETE_PRODUCT = 'DELETE_PRODUCT'
export const ADD_PRODUCT = 'ADD_PRODUCT'
export const SET_SELECTED_PRODUCT = 'SET_SELECTED_PRODUCT'
export const CLEAR_SELECTED_PRODUCT = 'CLEAR_SELECTED_PRODUCT'

const state = {
  products: {}
}

const getters = {
  getterAllProducts: (state) => state.products,
  getterSelectedProduct: (state) => state.selectedProduct
}

const mutations = {
  [GET_ALL_PRODUCTS] (state, value) {
    state.products = value
  },
  [DELETE_PRODUCT] (state, idProduct) {
    let i = state.products.map(item => item.idProduct).indexOf(idProduct)
    state.products.splice(i, 1)
  },
  [ADD_PRODUCT] (state, product) {
    state.products = state.products.concat(product)
  }
}

const actions = {
  actionGetAllProducts ({ commit }, response) {
    return productsApi.getAllProducts()
      .then((response) => {
        commit(GET_ALL_PRODUCTS, response.data)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionDeleteProduct ({ commit }, idProduct) {
    return productsApi.deleteProduct(idProduct)
      .then((response) => {
        commit(DELETE_PRODUCT, idProduct)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionCreateProduct ({ commit }, product) {
    return productsApi.createProduct(product)
      .then((response) => {
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionEditProduct ({ commit }, product) {
    return productsApi.editProduct(product)
      .then((response) => {
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  }
}

export default {
  state,
  getters,
  actions,
  mutations
}
