import { mapActions, mapGetters } from 'vuex'
import HeaderBar from '../../components/header-bar'

export default {
  components: {
    HeaderBar
  },
  data () {
    return {
      search: ''
    }
  },
  computed: {
    ...mapGetters([

    ])
  },

  methods: {
    ...mapActions([

    ])
  }
}
