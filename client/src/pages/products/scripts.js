import { mapGetters, mapActions } from 'vuex'
import headerBar from '../../components/header-bar'
import listProducts from '../../components/list-products'
import pieChart from '../../components/charts/pie-chart'
import { SweetModal } from 'sweet-modal-vue'
import moment from 'moment'

export default {
  components: {
    headerBar,
    listProducts,
    pieChart,
    SweetModal
  },
  data () {
    return {
      productName: null,
      productCod: null,
      productLote: null,
      productEst: null,
      productValid: null,
      productBuy: null,
      productSell: null,
      productDesc: null,
      productICMS: null,
      idLine: null,
      idProvider: null
    }
  },
  watch: {
  },
  computed: {
    ...mapGetters([
      'getterAllLines',
      'getterAllProviders'
    ])
  },
  mounted: function () {
  },
  methods: {
    ...mapActions([
      'actionCreateProduct'
    ]),
    openNewProduct () {
      this.$refs.newProduct.open()
    },
    close () {
      this.$refs.newProduct.close()
    },
    createProduct () {
      let newProduct = {
        statusProduct: true,
        codigoBarra: this.productCod,
        nome: this.productName,
        estoque: this.productEst,
        lote: this.productLote,
        dataValidade: moment(this.productValid).format(),
        dataCadastro: moment().format(),
        dataEntrada: moment().format(),
        precoCompra: this.productBuy,
        precoVenda: this.productSell,
        desconto: this.productDesc,
        icms: this.productICMS,
        idLine: this.idLine,
        idProvider: this.idProvider
      }
      this.actionCreateProduct(newProduct).then((result) => {
        console.log(result)
      }).catch((err) => {
        console.log(err)
      })
    }
  }
}
