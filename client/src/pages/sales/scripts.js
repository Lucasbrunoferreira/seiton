import { mapMutations, mapGetters } from 'vuex'
import HeaderBar from '../../components/header-bar'
import Const from '../../helpers/const'
import axios from 'axios'

export default {
  components: {
    HeaderBar
  },
  data () {
    return {
      saleCreate: false,
      sale: null,
      idSale: 1,
      selectedClient: null,
      selectedContribuitor: null,
      selectedProduct: null,
      product: null,
      qtd: null
    }
  },
  mounted () {

  },
  computed: {
    ...mapGetters([
      'getterAllUsers',
      'getterAllClients',
      'getterAllProducts',
      'getterAccount',
      'getterSale'
    ])
  },

  methods: {
    ...mapMutations([
      'ADD_SALE',
      'REMOVE_SALE_PRODUCT',
      'ADD_SALE_PRODUCT',
      'CLEAR_SALE'
    ]),

    addProduct () {

      axios.get(`${Const.PRODUCTS}/${this.selectedProduct}`)
        .then((res) => {
          this.product = res.data
          if (!this.getterSale) {
            let sale = {
              client: this.selectedClient,
              contribuitor: this.selectedContribuitor,
              products: [{
                idSale: this.idSale,
                product: this.product.nome,
                valor: this.product.precoVenda,
                qtd: this.qtd
              }]
            }
            this.ADD_SALE(sale)
          } else {
            this.idSale = this.idSale++
            let product = {
              idSale: this.idSale++,
              product: this.product.nome,
              valor: this.product.precoVenda,
              qtd: this.qtd
            }
            console.log(product)
            this.ADD_SALE_PRODUCT(product)
          }
        })
    },

    remover (product) {
      console.log(product.idSale)
      this.REMOVE_SALE_PRODUCT(product.idSale)
    },

    imprimir () {
      window.print()
    }
  }
}
