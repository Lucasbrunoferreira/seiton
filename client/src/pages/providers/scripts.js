import { mapActions, mapGetters } from 'vuex'
import HeaderBar from '../../components/header-bar'
import { SweetModal } from 'sweet-modal-vue'

export default {
  components: {
    HeaderBar,
    SweetModal
  },
  data () {
    return {
      selectedProvider: null,
      search: '',
      isManager: false,
      idProvider: '',
      nome: '',
      cnpj: '',
      cidade: '',
      responsavel: '',
      telefone: '',
      email: ''

    }
  },
  computed: {
    ...mapGetters([
      'getterAllProviders'
    ])
  },

  methods: {
    ...mapActions([
      'actionCreateProvider',
      'actionGetAllProviders',
      'actionDeleteProvider',
      'actionEditProvider'
    ]),
    openNewProvider () {
      this.$refs.newProvider.open()
    },
    manager (provider) {
      if (!this.isManager) {
        this.isManager = provider.idProvider
      } else {
        this.isManager = null
      }
    },
    close () {
      this.$refs.newProvider.close()
      this.$refs.delete.close()
      this.$refs.editProvider.close()
      this.clear()
    },
    clear () {
      this.nome = ''
      this.cnpj = ''
      this.cidade = ''
      this.responsavel = ''
      this.telefone = ''
      this.email = ''
    },
    createProvider () {
      let newProvider = {
        nome: this.nome,
        cnpj: this.cnpj,
        cidade: this.cidade,
        responsavel: this.responsavel,
        telefone: this.responsavel,
        email: this.email
      }
      this.actionCreateProvider(newProvider)
        .then(() => {
          this.$refs.newProvider.close()
          this.clear()
          this.$refs.creteSuccess.open()
          this.actionGetAllProviders().then((result) => {
            setTimeout(() => {
              this.$refs.creteSuccess.close()
            }, 2500)
          })
        })
        .catch(() => {
          this.$refs.newProvider.close()
          this.$refs.error.open()
          setTimeout(() => {
            this.$refs.error.close()
          }, 2500)
        })
    },
    openDelete (provider) {
      this.selectedProvider = provider
      this.$refs.delete.open()
    },
    confirmDelete () {
      this.actionDeleteProvider(this.selectedProvider.idProvider)
        .then((result) => {
          this.$refs.delete.close()
          this.$refs.deletedSuccess.open()
          setTimeout(() => {
            this.$refs.deletedSuccess.close()
            this.selectedProvider = null
          }, 2200)
        }).catch(() => {
          this.selectedProvider = null
          this.$refs.deletedError.open()
        })
    },
    openEdit (provider) {
      this.idProvider = provider.idProvider
      this.nome = provider.nome
      this.cnpj = provider.cnpj
      this.cidade = provider.cidade
      this.responsavel = provider.responsavel
      this.telefone = provider.telefone
      this.email = provider.email

      this.selectedProvider = provider
      this.$refs.editProvider.open()
    },
    salveProduct () {
      let newProvider = {
        idProvider: this.selectedProvider.idProvider,
        nome: this.nome,
        cnpj: this.cnpj,
        cidade: this.cidade,
        responsavel: this.responsavel,
        telefone: this.telefone,
        email: this.email
      }
      this.actionEditProvider(newProvider).then(() => {
        this.$refs.editProvider.close()
        this.clear()
        this.$refs.editedSuccess.open()
        this.actionGetAllProviders().then((result) => {
          setTimeout(() => {
            this.$refs.editedSuccess.close()
          }, 2500)
        })
      }).catch(() => {
        this.$refs.editProvider.close()
        this.$refs.error.open()
        setTimeout(() => {
          this.$refs.error.close()
        }, 2500)
      })
    }
  }
}
