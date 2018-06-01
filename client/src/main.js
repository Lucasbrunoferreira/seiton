import Vue from 'vue'
import App from './App'
import router from './router'
import store from './store'
import Vuex from 'vuex'
import Toasted from 'vue-toasted'
import VueCharts from 'vue-charts'
import VTooltip from 'v-tooltip'

Vue.config.productionTip = false

Vue.use(VueCharts)
Vue.use(VTooltip)
Vue.use(Vuex)

Vue.use(Toasted, ({
  iconPack: 'material'
}))

/* eslint-disable no-new */
new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
