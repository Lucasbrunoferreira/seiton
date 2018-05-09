import { navigationDrawer, headerBar, products, clients, newProduct } from '../../components/index'

export default {
  name: 'HomePage',
  components: {
    navigationDrawer,
    headerBar,
    products,
    clients,
    newProduct
  },
  data () {
    return {
    }
  },
  created: function () {
    if (!localStorage.idUser) {
      this.$router.push('/')
    }
  },
  methods: {
  }
}
