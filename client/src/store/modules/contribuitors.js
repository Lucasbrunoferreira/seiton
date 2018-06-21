import usersApi from '../../api/usersApi'

export const GET_ALL_USERS = 'GET_ALL_USERS'
export const DELETE_USER = 'DELETE_USER'

const state = {
  users: {}
}

const getters = {
  getterAllUsers: (state) => state.users
}

const mutations = {
  [GET_ALL_USERS] (state, value) {
    state.users = value
  },
  [DELETE_USER] (state, idContribuitor) {
    let i = state.users.map(item => item.idContribuitor).indexOf(idContribuitor)
    state.users.splice(i, 1)
  }
}

const actions = {
  actionGetAllUsers ({ commit }, response) {
    return usersApi.getAllUsers()
      .then((response) => {
        commit(GET_ALL_USERS, response.data)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionCreateUser ({ commit }, user) {
    return usersApi.createUser(user)
      .then((response) => {
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionEditUser ({ commit }, user) {
    return usersApi.editUser(user)
      .then((response) => {
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionDeleteUser ({ commit }, idContribuitor) {
    return usersApi.deleteUser(idContribuitor)
      .then((response) => {
        commit(DELETE_USER, idContribuitor)
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
