import providersApi from '../../api/providersApi'

export const GET_ALL_PROVIDERS = 'GET_ALL_PROVIDERS'

const state = {
  providers: {}
}

const getters = {
  getterAllProviders: (state) => state.providers
}

const mutations = {
  [GET_ALL_PROVIDERS] (state, value) {
    state.providers = value
  }
}

const actions = {
  actionGetAllProviders ({commit}, response) {
    return providersApi.getAllProviders()
      .then((response) => {
        commit(GET_ALL_PROVIDERS, response.data)
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
