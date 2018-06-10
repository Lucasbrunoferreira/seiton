import productsApi from '../../api/products.Api'

export const GET_ALL_PRODUCTS = 'GET_ALL_PRODUCTS'

const state = {
  products: {}
}

const getters = {
  getterAllProducts: (state) => state.products
}

const mutations = {
  [GET_ALL_PRODUCTS] (state, value) {
    state.products = value
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
  }
}

export default {
  state,
  getters,
  actions,
  mutations
}
