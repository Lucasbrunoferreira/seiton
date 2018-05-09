import Vue from 'vue'
import { App } from './screens'
import Vuetify from 'vuetify'
import router from './router'
import Firebase from 'firebase'

const config = {
  apiKey: 'AIzaSyCfPYpqzpspsWBQKBtd44ayHy3RbPVYLCQ',
  authDomain: 'seiton-35c94.firebaseapp.com',
  databaseURL: 'https://seiton-35c94.firebaseio.com',
  projectId: 'seiton-35c94',
  storageBucket: 'seiton-35c94.appspot.com',
  messagingSenderId: '1051184368560'
}

const firebaseApp = Firebase.initializeApp(config)

Vue.use(firebaseApp)

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
