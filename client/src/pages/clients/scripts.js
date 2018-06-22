import { mapActions, mapGetters } from 'vuex'
import HeaderBar from '../../components/header-bar'
import { SweetModal } from 'sweet-modal-vue'
import moment from 'moment'

export default {
  components: {
    HeaderBar,
    SweetModal
  },
  data () {
    return {
      search: '',
      isManager: false,
      selectedClient: null,
      nomeRazaoSocial: null,
      cpf: null,
      dataNascimento: null,
      cep: null,
      cidade: null,
      bairro: null,
      rua: null,
      numeroDaCasa: null,
      pontoReferencia: null,
      estado: null,
      telefone: null,
      email: null
    }
  },
  computed: {
    ...mapGetters([
      'getterAllClients'
    ])
  },

  methods: {
    ...mapActions([
      'actionCreateClient',
      'actionGetAllClients',
      'actionDeleteClient',
      'actionEditClient'
    ]),

    manager (client) {
      if (!this.isManager) {
        this.isManager = client.idClient
      } else {
        this.isManager = null
      }
    },

    openCreate () {
      this.$refs.newClient.open()
    },

    openEdit (client) {
      this.selectedClient = client
      this.nomeRazaoSocial = client.nomeRazaoSocial
      this.cpf = client.cpf
      this.dataNascimento = client.dataNascimento
      this.cep = client.cep
      this.cidade = client.cidade
      this.bairro = client.bairro
      this.rua = client.rua
      this.numeroDaCasa = client.numeroDaCasa
      this.pontoReferencia = client.pontoReferencia
      this.estado = client.estado
      this.telefone = client.telefone
      this.email = client.email

      this.$refs.editClient.open()
    },

    openDelete (client) {
      this.selectedClient = client
      this.$refs.delete.open()
    },

    close () {
      this.clear()
      this.$refs.newClient.close()
      this.$refs.delete.close()
      this.$refs.editClient.close()
    },

    clear () {
      this.search = null
      this.nomeRazaoSocial = null
      this.cpf = null
      this.dataNascimento = null
      this.cep = null
      this.cidade = null
      this.bairro = null
      this.rua = null
      this.numeroDaCasa = null
      this.pontoReferencia = null
      this.estado = null
      this.telefone = null
      this.email = null
    },

    createClient () {
      let newClient = {
        nomeRazaoSocial: this.nomeRazaoSocial,
        cpf: this.cpf,
        dataNascimento: moment(this.dataNascimento).format(),
        cep: this.cep,
        cidade: this.cidade,
        bairro: this.bairro,
        rua: this.rua,
        numeroDaCasa: parseInt(this.numeroDaCasa),
        pontoReferencia: this.pontoReferencia,
        estado: this.estado,
        telefone: this.telefone,
        email: this.email,
        dataCadastro: moment().format()
      }

      this.actionCreateClient(newClient)
        .then(() => {
          this.$refs.newClient.close()
          this.clear()
          this.$refs.createdSuccess.open()
          this.actionGetAllClients()
            .then(() => {
              setTimeout(() => {
                this.$refs.createdSuccess.close()
              }, 2500)
            })
        })
        .catch(() => {
          this.$refs.newClient.close()
          this.$refs.error.open()
          setTimeout(() => {
            this.$refs.error.close()
          }, 2500)
        })
    },

    confirmDelete () {
      this.actionDeleteClient(this.selectedClient.idClient)
        .then(() => {
          this.$refs.delete.close()
          this.$refs.deletedSuccess.open()
          setTimeout(() => {
            this.$refs.deletedSuccess.close()
            this.selectedClient = null
          }, 2200)
        })
        .catch(() => {
          this.selectedClient = null
          this.$refs.error.open()
        })
    },

    salveClient () {
      let newClient = {
        idClient: this.selectedClient.idClient,
        nomeRazaoSocial: this.nomeRazaoSocial,
        cpf: this.cpf,
        dataNascimento: moment(this.dataNascimento).format(),
        cep: this.cep,
        cidade: this.cidade,
        bairro: this.bairro,
        rua: this.rua,
        numeroDaCasa: parseInt(this.numeroDaCasa),
        pontoReferencia: this.pontoReferencia,
        estado: this.estado,
        telefone: this.telefone,
        email: this.email,
        dataCadastro: moment().format()
      }

      this.actionEditClient(newClient).then(() => {
        this.$refs.editClient.close()
        this.clear()
        this.$refs.editedSuccess.open()
        this.actionGetAllClients().then((result) => {
          setTimeout(() => {
            this.$refs.editedSuccess.close()
          }, 2500)
        })
      }).catch(() => {
        this.$refs.editClient.close()
        this.$refs.error.open()
        setTimeout(() => {
          this.$refs.error.close()
        }, 2500)
      })
    }

  }
}
