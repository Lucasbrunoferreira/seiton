import Vue from 'vue'
import { App } from './screens'
import Vuetify from 'vuetify'
import router from './router'

Vue.use(Vuetify, {
  theme: {
    primary: '#132135',
    secondary: '#6BD8D1'
  }
})
Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  components: { App },
  template: '<App/>'
})
