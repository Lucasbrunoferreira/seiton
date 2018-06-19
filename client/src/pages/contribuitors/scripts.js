import { mapActions, mapGetters } from 'vuex'
import HeaderBar from '../../components/header-bar'

export default {
  components: {
    HeaderBar
  },
  data () {
    return {
      isManager: false
    }
  },
  computed: {
    ...mapGetters([

    ])
  },

  methods: {
    ...mapActions([

    ]),
    showManager () {
      this.isManager = !this.isManager
    }
  }
}
