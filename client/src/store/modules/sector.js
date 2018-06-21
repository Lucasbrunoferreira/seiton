import sectorApi from '../../api/sectorApi'

export const GET_ALL_SECTORS = 'GET_ALL_SECTORS'
export const GET_CURRENT_SECTOR = 'GET_CURRENT_SECTOR'

const state = {
  sectors: {},
  currentSector: {}
}

const getters = {
  getterAllSectors: (state) => state.sectors,
  getterCurrentSector: (state) => state.currentSector
}

const mutations = {
  [GET_ALL_SECTORS] (state, value) {
    state.sectors = value
  },
  [GET_CURRENT_SECTOR] (state, value) {
    state.currentSector = value
  }
}

const actions = {
  actionGetAllSectors ({ commit }, response) {
    return sectorApi.getAllSectors()
      .then((response) => {
        commit(GET_ALL_SECTORS, response.data)
        return Promise.resolve(response)
      })
      .catch((e) => {
        return Promise.reject(e)
      })
  },
  actionGetCurrentSector ({ commit }, params) {
    return sectorApi.getCurrentSector(params.idSector)
      .then((response) => {
        commit(GET_CURRENT_SECTOR, response.data)
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
