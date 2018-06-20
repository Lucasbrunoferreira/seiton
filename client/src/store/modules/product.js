import productsApi from '../../api/products.Api'

export const GET_ALL_PRODUCTS = 'GET_ALL_PRODUCTS'
export const DELETE_PRODUCT = 'DELETE_PRODUCT'
export const ADD_PRODUCT = 'ADD_PRODUCT'

const state = {
  products: {}
}

const getters = {
  getterAllProducts: (state) => state.products
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
    state.all = state.products.concat(product)
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
        console.log(response)
        commit(DELETE_PRODUCT, idProduct)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionCreateProduct ({ commit }, params) {
    console.log(params)
    return productsApi.createProduct(params)
      .then((response) => {
        // commit(ADD_PRODUCT, response.data)
        console.log(response)
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
