import axios from 'axios'
import { PRODUCTS } from '../../helpers/const'

export default {
  data () {
    return {
      snackbar: false,
      color: '',
      mode: '',
      timeout: 6000,
      text: '',
      totalItems: null,
      products: [],
      items: [],
      search: '',
      isOpen: false,
      idProduto: null,
      headers: [{
        text: 'Descrição do Produto',
        align: 'left',
        value: 'nome'
      },
      {
        text: 'Cod. Barras',
        value: 'codigoBarra'
      },
      {
        text: 'Estoque',
        value: 'estoque'
      },
      {
        text: 'Preço Compra',
        value: 'precoCompra'
      },
      {
        text: 'Preço Venda',
        value: 'precoVenda'
      },
      {
        text: 'Desconto',
        value: 'desconto'
      }]
    }
  },
  created () {
    axios.get(PRODUCTS)
      .then(response => {
        this.items = response.data
        this.totalItems = Object.keys(this.items).length
      })
      .catch(e => {
        this.errors.push(e)
      })
  },
  computed: {
    pages () {
      if (this.pagination.rowsPerPage == null ||
        this.pagination.totalItems == null
      ) return 0
      return Math.ceil(this.pagination.totalItems / this.pagination.rowsPerPage)
    }
  },
  methods: {
    itemEdit (item) {
      console.log(item)
      window.localStorage.setItem('itemToEdit', JSON.stringify(item))
      this.$router.push('/produtos/novo')
    },
    openDelete (value) {
      this.idProduto = value
      this.isOpen = true
    },
    itemDelete () {
      this.isOpen = false
      axios.delete(PRODUCTS + this.idProduto)
        .then(response => {
          this.color = 'success'
          this.text = 'Produto excluido com sucesso!'
          this.snackbar = true
          axios.get(PRODUCTS)
            .then(response => {
              this.items = response.data
              this.totalItems = Object.keys(this.items).length
            })
            .catch(e => {
              this.errors.push(e)
            })
        })
        .catch(e => {
          console.warn(e)
          this.color = 'error'
          this.text = 'Houve um erro inesperado!'
          this.snackbar = true
        })
    }
  }
}
