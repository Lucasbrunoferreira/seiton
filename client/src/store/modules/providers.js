import providersApi from '../../api/providersApi'

export const GET_ALL_PROVIDERS = 'GET_ALL_PROVIDERS'
export const DELETE_PROVIDER = 'DELETE_PROVIDER'

const state = {
  providers: {}
}

const getters = {
  getterAllProviders: (state) => state.providers
}

const mutations = {
  [GET_ALL_PROVIDERS] (state, value) {
    state.providers = value
  },
  [DELETE_PROVIDER] (state, idProvider) {
    let i = state.providers.map(item => item.idProvider).indexOf(idProvider)
    state.providers.splice(i, 1)
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
  },
  actionCreateProvider ({commit}, provider) {
    return providersApi.createProvider(provider)
      .then((response) => {
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionDeleteProvider ({ commit }, idProvider) {
    return providersApi.deleteProvider(idProvider)
      .then((response) => {
        commit(DELETE_PROVIDER, idProvider)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionEditProvider ({ commit }, provider) {
    return providersApi.editProvider(provider)
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
