import Vue from 'vue'
import Vuex from 'vuex'
import createPersistedState from 'vuex-persistedstate'
import clients from './modules/clients'
import account from './modules/account'
import sector from './modules/sector'

Vue.use(Vuex)

export default new Vuex.Store({
  modules: {
    clients,
    account,
    sector
  },
  plugins: [createPersistedState()]
})
