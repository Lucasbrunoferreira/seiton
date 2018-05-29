import Vue from 'vue'
import Vuex from 'vuex'
import createPersistedState from 'vuex-persistedstate'
import clients from './modules/clients'

Vue.use(Vuex)

export default new Vuex.Store({
  modules: {
    clients
  },
  plugins: [createPersistedState()]
})
