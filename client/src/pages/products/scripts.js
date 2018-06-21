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
      'actionCreateProduct',
      'actionGetAllProducts'
    ]),
    openNewProduct () {
      this.$refs.newProduct.open()
    },
    close () {
      this.$refs.newProduct.close()
      this.clear()
    },
    clear () {
      this.productName = null
      this.productCod = null
      this.productLote = null
      this.roductEst = null
      this.roductValid = null
      this.roductBuy = null
      this.productSell = null
      this.roductDesc = null
      this.roductICMS = null
      this.dLine = null
      this.dProvider = null
    },
    createProduct () {
      let newProduct = {
        statusProduct: true,
        codigoBarra: this.productCod,
        nome: this.productName,
        estoque: parseInt(this.productEst),
        lote: this.productLote,
        dataValidade: moment(this.productValid).format(),
        dataCadastro: moment().format(),
        dataEntrada: moment().format(),
        precoCompra: parseInt(this.productBuy),
        precoVenda: parseInt(this.productSell),
        desconto: parseInt(this.productDesc),
        icms: parseInt(this.productICMS),
        idLine: parseInt(this.idLine),
        idProvider: parseInt(this.idProvider)
      }
      this.actionCreateProduct(newProduct).then(() => {
        this.$refs.newProduct.close()
        this.clear()
        this.$refs.createdSuccess.open()
        this.actionGetAllProducts().then((result) => {
          setTimeout(() => {
            this.$refs.createdSuccess.close()
          }, 2500)
        })
      }).catch(() => {
        this.$refs.newProduct.close()
        this.$refs.createError.open()
        setTimeout(() => {
          this.$refs.createError.close()
        }, 2500)
      })
    }
  }
}
