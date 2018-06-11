import { mapGetters, mapMutations, mapActions } from 'vuex'
import moment from 'moment'
import { SweetModal } from 'sweet-modal-vue'

export default {
  components: {
    SweetModal
  },
  data () {
    return {
      selectedProduct: null,
      filteredLine: null,
      moreInfo: null,
      search: '',
      idLine: null,
      crt: false,
      war: false,
      ok: false
    }
  },
  computed: {
    ...mapGetters([
      'getterAllProducts',
      'getterAllLines'

    ]),
    filteredProducts: function () {
      var self = this
      var search = this.search
      var line = this.filteredLine
      var selectedLine = this.idLine
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
      this.idLine = parseInt(line.substring(0, 1))
    }
  },
  mounted: function () {
    this.getterAllProducts.forEach(product => {
      this.validadeFormatada = moment(product.dataValidade).format('L')
      product.dataValidade = this.validadeFormatada
    })
  },
  methods: {
    ...mapMutations([
      'SET_FORMATTED_DATE'
    ]),
    ...mapActions([
      'actionDeleteProduct',
      'actionGetIdLine'
    ]),

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
    }

  }
}
