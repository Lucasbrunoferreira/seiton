export default {
  data () {
    return {
      drawer: true,
      items: [{
        title: 'Produtos',
        icon: '../../../static/icons/products.svg'
      }],
      mini: true,
      right: null
    }
  },
  methods: {
    ola () {
      this.$router.push('/')
    }
  }
}
