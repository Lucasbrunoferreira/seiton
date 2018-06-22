import clientApi from '../../api/clientApi'

export const GET_ALL_CLIENTS = 'GET_ALL_CLIENTS'
export const DELETE_CLIENT = 'DELETE_CLIENT'

const state = {
  clients: {}
}

const getters = {
  getterAllClients: (state) => state.clients
}

const mutations = {
  [GET_ALL_CLIENTS] (state, value) {
    state.clients = value
  },
  [DELETE_CLIENT] (state, idClient) {
    let i = state.clients.map(item => item.idContribuitor).indexOf(idClient)
    state.clients.splice(i, 1)
  }
}

const actions = {
  actionGetAllClients ({ commit }) {
    return clientApi.getAllClients()
      .then((response) => {
        commit(GET_ALL_CLIENTS, response.data)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionCreateClient ({ commit }, client) {
    return clientApi.createClient(client)
      .then((response) => {
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionEditClient ({ commit }, client) {
    return clientApi.editClient(client)
      .then((response) => {
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionDeleteClient ({ commit }, idClient) {
    return clientApi.deleteClient(idClient)
      .then((response) => {
        commit(DELETE_CLIENT, idClient)
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
