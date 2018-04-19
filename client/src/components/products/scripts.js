import axios from 'axios'

export default {
  data () {
    return {
      totalItems: null,
      products: [],
      items: [],
      search: '',
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
    axios.get(`http://localhost:58538/api/products`)
      .then(response => {
        this.items = response.data
        this.totalItems = Object.keys(this.items).length
        console.log(this.totalItems)
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
    ola () {
      alert('ola')
    }
  }
}
