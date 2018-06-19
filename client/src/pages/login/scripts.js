import { mapActions, mapGetters } from 'vuex'

export default {
  data () {
    return {
      usuario: null,
      senha: null
    }
  },
  computed: {
    ...mapGetters([
      'getterAccount'
    ])
  },
  methods: {
    ...mapActions([
      'actionLogin',
      'actionGetCurrentSector',
      'actionGetAllSectors'
    ]),
    login () {
      if (this.usuario && this.senha) {
        this.actionLogin({usuario: this.usuario, senha: this.senha})
          .then((response) => {
            this.$toasted.success('Autenticado com sucesso!', {
              icon: 'fingerprint',
              theme: 'bubble',
              position: 'top-right',
              duration: 2000
            })
            this.actionGetCurrentSector(this.getterAccount)
            this.actionGetAllSectors()
            setTimeout(() => {
              this.$router.push('/home')
            }, 3000)
          }).catch((e) => {
            this.$toasted.error('Erro ao autenticar!', {
              icon: 'error',
              theme: 'bubble',
              position: 'top-right',
              duration: 2500
            })
          })
      }
    }
  }
}
