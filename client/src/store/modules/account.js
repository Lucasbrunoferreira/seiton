import usersApi from '../../api/usersApi'

export const LOGIN_SERVICE = 'LOGIN_SERVICE'
export const LOGOUT_SERVICE = 'LOGOUT_SERVICE'

const state = {
  currentAccount: {}
}

const getters = {
  getterAccount: (state) => state.currentAccount
}

const mutations = {
  [LOGIN_SERVICE] (state, value) {
    state.currentAccount = value
  },
  [LOGOUT_SERVICE] (state, value) {
    state.currentAccount = {}
  }
}

const actions = {
  actionLogin ({ commit }, params) {
    return usersApi.signIn(params.usuario, params.senha)
      .then((response) => {
        commit(LOGIN_SERVICE, response.data)
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
