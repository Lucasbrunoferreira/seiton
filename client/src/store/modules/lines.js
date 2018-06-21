import linesApi from '../../api/linesApi'

export const GET_ALL_LINES = 'GET_ALL_LINES'

const state = {
  lines: {}
}

const getters = {
  getterAllLines: (state) => state.lines
}

const mutations = {
  [GET_ALL_LINES] (state, value) {
    state.lines = value
  }
}

const actions = {
  actionGetAllLines ({commit}, response) {
    return linesApi.getAllLines()
      .then((response) => {
        commit(GET_ALL_LINES, response.data)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionGetIdLine ({commit}, idLine) {
    return linesApi.getIdLine(idLine)
      .then((result) => {
        return result
      })
      .catch((err) => {
        return err
      })
  }
}

export default {
  state,
  getters,
  actions,
  mutations
}
