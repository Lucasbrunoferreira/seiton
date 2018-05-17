import axios from 'axios'
import { PRODUCTS } from '../../../helpers/const'

export default {
  name: 'newProduct',
  data () {
    return {
      titulo: 'Novo Produto',
      editProduct: {},
      valid: true,
      descricao: null,
      descricaoRules: [
        v => !!v || 'Descrição é obrigatória!',
        v => (v && v.length <= 60) || 'A descrição excede 60 caracteres!'
      ],
      codBarras: null,
      codBarrasRules: [
        v => !!v || 'Código de barras é obrigatório!',
        v => (v && v.length <= 20) || 'O código de barras excede 20 caracteres!'
      ],
      select: null,
      dataValidade: null,
      dtValRules: [
        v => !!v || 'Data de validade é obrigatória!'
      ],
      dataAtual: null,
      precoCompra: null,
      prCompraRules: [
        v => !!v || 'Preço de compra é obrigatório!'
      ],
      precoVenda: 0,
      prVendaRules: [
        v => !!v || 'Preço de venda é obrigatório!'
      ],
      desconto: null,
      descontoRules: [
        v => !!v || 'Desconto é obrigatório!'
      ],
      icms: null,
      icmsRules: [
        v => !!v || 'ICMS é obrigatório!'
      ],
      linha: null,
      items: [
        { id: 1, text: 'Medicamentos' },
        { id: 2, text: 'Alimentos' }

      ],
      fornecedor: null,
      providers: [
        { text: 'Teuto Brasil' },
        { text: 'Neo Quimica' }
      ],
      snackbar: false,
      y: null,
      x: null,
      mode: '',
      timeout: 6000,
      text: '',
      color: ''
    }
  },
  methods: {
    clear () {
      this.$refs.form.reset()
      this.dataValidade = ''
    },
    cancelar () {
      window.localStorage.removeItem('itemToEdit')
      this.$refs.form.reset()
      this.dataValidade = ''
      this.$router.push('/produtos')
    },
    submit () {
      if (localStorage.itemToEdit) {
        axios.put(PRODUCTS + this.editProduct.idProduct,
          {
            statusProduct: true,
            codigoBarra: parseInt(this.codBarras),
            nome: this.descricao,
            estoque: 10,
            lote: '4876',
            dataValidade: this.dataValidade,
            dataCadastro: this.dataAtual,
            dataEntrada: this.dataAtual,
            precoCompra: parseInt(this.precoCompra),
            precoVenda: parseInt(this.precoVenda),
            desconto: parseInt(this.desconto),
            icms: parseInt(this.icms),
            idLine: 1,
            idProvider: 1
          }).then((response) => {
          this.color = 'success'
          this.text = 'Produto alterado com sucesso!'
          this.snackbar = true
          this.$refs.form.reset()
          this.dataValidade = ''
          window.localStorage.removeItem('itemToEdit')
          setTimeout(() => {
            this.$router.push('/produtos')
          }, 3500)
        }).catch(() => {
          this.color = 'error'
          this.text = 'Erro ao alterar o produto!'
          this.snackbar = true
        })
      } else {
        axios.post(PRODUCTS,
          {
            statusProduct: true,
            codigoBarra: parseInt(this.codBarras),
            nome: this.descricao,
            estoque: 10,
            lote: '4876',
            dataValidade: this.dataValidade,
            dataCadastro: this.dataAtual,
            dataEntrada: this.dataAtual,
            precoCompra: parseInt(this.precoCompra),
            precoVenda: parseInt(this.precoVenda),
            desconto: parseInt(this.desconto),
            icms: parseInt(this.icms),
            idLine: 1,
            idProvider: 1
          }).then((response) => {
          this.color = 'success'
          this.text = 'Produto cadastrado com sucesso!'
          this.snackbar = true
          this.$refs.form.reset()
          this.dataValidade = ''
        }).catch(() => {
          this.color = 'error'
          this.text = 'Erro ao cadastrar produto!'
          this.snackbar = true
        })
      }
    },
    formatDate (date) {
      if (!date) {
        return null
      }

      const [year, month, day] = date.split('-')
      return `${month}/${day}/${year}`
    },
    parseDate (date) {
      if (!date) {
        return null
      }
      const [month, day, year] = date.split('/')
      return `${year}/${month.padStart(2, '0')}/${day.padStart(2, '0')}`
    }
  },
  created () {
    if (localStorage.itemToEdit) {
      this.titulo = 'Editar Produto'
      this.editProduct = JSON.parse(window.localStorage.getItem('itemToEdit'))
      this.descricao = this.editProduct.nome
      this.codBarras = this.editProduct.codigoBarra
      this.precoCompra = this.editProduct.precoCompra
      this.precoVenda = this.editProduct.precoVenda
      this.desconto = this.editProduct.desconto
      this.icms = this.editProduct.icms
    }

    let today = new Date()
    let dd = today.getDate()
    let mm = today.getMonth() + 1
    let yyyy = today.getFullYear()

    if (dd < 10) {
      dd = '0' + dd
    }

    if (mm < 10) {
      mm = '0' + mm
    }
    this.dataAtual = dd + '/' + mm + '/' + yyyy
  }
}
