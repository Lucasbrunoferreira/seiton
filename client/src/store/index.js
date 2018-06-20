import Vue from 'vue'
import Vuex from 'vuex'
import createPersistedState from 'vuex-persistedstate'
import client from './modules/client'
import account from './modules/account'
import sector from './modules/sector'
import product from './modules/product'
import lines from './modules/lines'
import providers from './modules/providers'

Vue.use(Vuex)

export default new Vuex.Store({
  modules: {
    client,
    account,
    sector,
    product,
    lines,
    providers
  },
  plugins: [createPersistedState()]
})
