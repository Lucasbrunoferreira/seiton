import usersApi from '../../api/usersApi'

export const LOGIN_SERVICE = 'LOGIN_SERVICE'
export const LOGOUT_SERVICE = 'LOGOUT_SERVICE'

const state = {
  account: {}
}

const getters = {
  getterAccount: (state) => state.account
}

const mutations = {
  [LOGIN_SERVICE] (state, value) {
    state.account = value
  },
  [LOGOUT_SERVICE] (state, value) {
    state.account.currentUser = {}
  }
}

const actions = {
  actionLogin ({ commit }, params) {
    return usersApi.signIn(params.usuario, params.senha)
      .then((response) => {
        commit(LOGIN_SERVICE, {
          'currentUser': (response.data)
        })
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
