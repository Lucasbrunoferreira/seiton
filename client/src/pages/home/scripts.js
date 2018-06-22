import headerBar from '../../components/header-bar'
import chartLine from '../../components/charts/line-chart'
import chartBar from '../../components/charts/bar-chart'
import { mapActions, mapGetters } from 'vuex'

export default {
  components: {
    headerBar,
    chartLine,
    chartBar
  },
  data () {
    return {

    }
  },
  computed: {
    ...mapGetters([
      'getterAccount'
    ])
  },
  mounted: function () {
    this.actionGetAllSectors()
    this.actionGetAllProducts()
    this.actionGetAllLines()
    this.actionGetAllProviders()
    this.actionGetAllUsers()
    this.actionGetAllClients()
  },
  methods: {
    ...mapActions([
      'actionGetAllSectors',
      'actionGetAllProducts',
      'actionGetAllLines',
      'actionGetAllProviders',
      'actionGetAllUsers',
      'actionGetAllClients'
    ]),
    toPage (route) {
      this.$router.push(route)
    }
  }
}
