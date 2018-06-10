import { mapGetters } from 'vuex'
import headerBar from '../../components/header-bar'
import listProducts from './modals/list-products'

export default {
  components: {
    headerBar,
    listProducts
  },
  data () {
    return {
    }
  },
  computed: {
    ...mapGetters([

    ])
  },
  mounted: function () {

  },
  methods: {
  }
}
