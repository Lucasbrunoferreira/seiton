import { mapGetters, mapMutations, mapActions } from 'vuex'
import moment from 'moment'
import { SweetModal } from 'sweet-modal-vue'

export default {
  components: {
    SweetModal
  },
  data () {
    return {
      idProduct: null,
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
      idProvider: null,
      selectedProduct: null,
      filteredLine: null,
      moreInfo: null,
      search: '',
      prductLine: null,
      crt: false,
      war: false,
      ok: false
    }
  },
  computed: {
    ...mapGetters([
      'getterAllProducts',
      'getterAllProviders',
      'getterAllLines'

    ]),
    filteredProducts: function () {
      var self = this
      var search = this.search
      var line = this.filteredLine
      var selectedLine = this.prductLine
      return this.getterAllProducts.filter(function (products) {
        if (line === 'Todos') {
          return products
        }
        if (search !== '') {
          return products.nome.toLowerCase().indexOf(self.search.toLowerCase()) >= 0
        } else if (line !== null) {
          return products.idLine === selectedLine
        } else {
          return products
        }
      })
    }
  },
  watch: {
    filteredLine: function (line) {
      this.prductLine = parseInt(line.substring(0, 1))
    }
  },
  mounted () {
    this.parseDate()
  },
  methods: {
    ...mapMutations([
      'SET_FORMATTED_DATE',
      'SET_SELECTED_PRODUCT'
    ]),
    ...mapActions([
      'actionDeleteProduct',
      'actionGetIdLine',
      'actionEditProduct',
      'actionGetAllProducts'
    ]),

    parseDate () {
      this.getterAllProducts.forEach(product => {
        this.validadeFormatada = moment(product.dataValidade).format('L')
        product.dataValidade = this.validadeFormatada
      })
    },

    showInfo (item) {
      if (!this.moreInfo) {
        this.moreInfo = item.idProduct
      } else {
        this.moreInfo = null
      }
    },

    openDelete (idProduct) {
      this.selectedProduct = idProduct
      this.$refs.delete.open(idProduct)
    },

    confirmDelete () {
      this.actionDeleteProduct(this.selectedProduct)
        .then((result) => {
          this.parseDate()
          this.$refs.delete.close()
          this.$refs.deletedSuccess.open()
          setTimeout(() => {
            this.$refs.deletedSuccess.close()
            this.selectedProduct = null
          }, 2200)
        }).catch(() => {
          this.selectedProduct = null
          this.$refs.deletedError.open()
        })
    },

    close: function () {
      this.$refs.delete.close()
      this.$refs.deletedError.close()
      this.$refs.editProduct.close()
    },

    editProduct (product) {
      this.productName = product.nome
      this.productCod = product.codigoBarra
      this.productLote = product.lote
      this.productEst = product.estoque
      this.productValid = product.dataValidade
      this.productBuy = product.precoCompra
      this.productSell = product.precoVenda
      this.productDesc = product.desconto
      this.productICMS = product.icms
      this.idProduct = product.idProduct

      this.$refs.editProduct.open()
    },

    clear () {
      this.productName = ''
      this.productCod = ''
      this.productLote = ''
      this.productEst = ''
      this.productValid = ''
      this.productBuy = ''
      this.productSell = ''
      this.productDesc = ''
      this.productICMS = ''
      this.idProduct = ''
    },

    salveProduct () {
      let newProduct = {
        id: this.idProduct,
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
      this.actionEditProduct(newProduct).then(() => {
        this.$refs.editProduct.close()
        this.parseDate()
        this.$refs.editedSuccess.open()
        this.actionGetAllProducts().then((result) => {
          this.clear()
          setTimeout(() => {
            this.$refs.editedSuccess.close()
          }, 2500)
        })
      }).catch(() => {
        this.$refs.editProduct.close()
        this.$refs.deletedError.open()
        setTimeout(() => {
          this.$refs.deletedError.close()
        }, 2500)
      })
    }

  }
}
