import { mapGetters } from 'vuex'
import headerBar from '../../components/header-bar'
import listProducts from '../../components/list-products'
import pieChart from '../../components/charts/pie-chart'

export default {
  components: {
    headerBar,
    listProducts,
    pieChart
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
