import { mapActions, mapGetters } from 'vuex'
import HeaderBar from '../../components/header-bar'
import moment from 'moment'
import { SweetModal } from 'sweet-modal-vue'

export default {
  components: {
    HeaderBar,
    SweetModal
  },
  data () {
    return {
      isManager: false,
      nascFormatada: '',
      nome: null,
      usuario: null,
      senha: null,
      confirmSenha: null,
      cpf: null,
      dataNascimento: null,
      dataCadastro: null,
      idSector: null,
      selectedContribuitor: null
    }
  },
  computed: {
    ...mapGetters([
      'getterAllUsers',
      'getterAllSectors'
    ])
  },
  mounted: function () {
    this.getterAllUsers.forEach(user => {
      this.nascFormatada = moment(user.dataNascimento).locale('pt-br').format('L')
      user.dataNascimento = this.nascFormatada
    })
  },
  methods: {
    ...mapActions([
      'actionCreateUser',
      'actionGetAllUsers',
      'actionEditUser',
      'actionDeleteUser'
    ]),
    showManager (contribuitor) {
      if (!this.isManager) {
        this.isManager = contribuitor.idContribuitor
      } else {
        this.isManager = null
      }
    },
    clear () {
      this.nome = ''
      this.usuario = ''
      this.senha = ''
      this.confirmSenha = ''
      this.cpf = ''
      this.dataNascimento = ''
      this.dataCadastro = ''
      this.idSector = ''
    },
    openCreate () {
      this.$refs.newUser.open()
    },
    close () {
      this.$refs.newUser.close()
      this.$refs.editUser.close()
      this.$refs.delete.close()
      this.clear()
    },
    editContribuitor (contribuitor) {
      this.selectedContribuitor = contribuitor
      this.$refs.editUser.open()
      this.nome = contribuitor.nome
      this.usuario = contribuitor.usuario
      this.cpf = contribuitor.cpf
      this.dataNascimento = contribuitor.dataNascimento
    },
    salveUser () {
      if (this.senha === this.confirmSenha) {
        let newUser = {
          idContribuitor: this.selectedContribuitor.idContribuitor,
          nome: this.nome,
          usuario: this.usuario,
          senha: this.senha,
          cpf: this.cpf,
          dataNascimento: moment(this.dataNascimento).format(),
          dataCadastro: moment().format(),
          idSector: this.idSector
        }

        this.actionEditUser(newUser).then(() => {
          this.$refs.editUser.close()
          this.clear()
          this.$refs.editeSuccess.open()
          this.actionGetAllUsers().then(() => {
            this.getterAllUsers.forEach(user => {
              this.nascFormatada = moment(user.dataNascimento).locale('pt-br').format('L')
              user.dataNascimento = this.nascFormatada
            })
            setTimeout(() => {
              this.$refs.editeSuccess.close()
            }, 2500)
          })
        }).catch(() => {
          this.$refs.editUser.close()
          this.$refs.error.open()
          setTimeout(() => {
            this.$refs.error.close()
          }, 2500)
        })
      } else {
        this.$toasted.error('As senhas não se coincidem!', {
          icon: 'error',
          theme: 'bubble',
          position: 'top-right',
          duration: 2500
        })
      }
    },
    createUser () {
      if (this.senha === this.confirmSenha) {
        let newUser = {
          nome: this.nome,
          usuario: this.usuario,
          senha: this.senha,
          cpf: this.cpf,
          dataNascimento: moment(this.dataNascimento).format(),
          dataCadastro: moment().format(),
          idSector: this.idSector
        }

        this.actionCreateUser(newUser).then(() => {
          this.$refs.newUser.close()
          this.clear()
          this.$refs.createdSuccess.open()
          this.actionGetAllUsers().then(() => {
            this.mounted()
            setTimeout(() => {
              this.$refs.createdSuccess.close()
            }, 2500)
          })
        }).catch(() => {
          this.$refs.newUser.close()
          this.$refs.error.open()
          setTimeout(() => {
            this.$refs.error.close()
          }, 2500)
        })
      } else {
        this.$toasted.error('As senhas não se coincidem!', {
          icon: 'error',
          theme: 'bubble',
          position: 'top-right',
          duration: 2500
        })
      }
    },
    deleteContribuitor (contribuitor) {
      this.selectedContribuitor = contribuitor
      this.$refs.delete.open()
    },
    confirmDelete () {
      this.actionDeleteUser(this.selectedContribuitor.idContribuitor)
        .then((result) => {
          this.$refs.delete.close()
          this.$refs.deletedSuccess.open()
          setTimeout(() => {
            this.$refs.deletedSuccess.close()
            this.selectedContribuitor = null
          }, 2200)
        }).catch(() => {
          this.selectedContribuitor = null
          this.$refs.error.open()
        })
    }
  }
}
