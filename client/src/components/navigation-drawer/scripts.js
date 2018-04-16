export default {
  data () {
    return {
      currentRoute: this.$router.history.current.name,
      drawer: true,
      items: [{
        title: 'Produtos',
        icon: '../../../static/icons/products.png',
        route: '/produtos'
      },
      {
        title: 'Clientes',
        icon: '../../../static/icons/clients.png',
        route: '/clientes'
      }],
      mini: true,
      right: null
    }
  },
  methods: {

  }
}
