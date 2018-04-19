export default {
  name: 'newProduct',
  data () {
    return {
      valid: true,
      name: '',
      nameRules: [
        v => !!v || 'Descrição é obrigatória!',
        v => (v && v.length <= 60) || 'A descrição excede 60 caracteres!'
      ],
      codBarras: '',
      codBarrasRules: [
        v => !!v || 'Código de barras é obrigatório!',
        v => (v && v.length <= 20) || 'O código de barras excede 20 caracteres!'
      ],
      select: null,
      items: [
        'Item 1',
        'Item 2',
        'Item 3',
        'Item 4'
      ]
    }
  },
  methods: {
    clear () {
      this.$refs.form.reset()
    },
    submit () {
      console.log(this.name)
    }
  }
}
