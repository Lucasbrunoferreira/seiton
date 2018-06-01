import { mapGetters, mapMutations } from 'vuex'

export default {
  data () {
    return {
      userName: null,
      userSector: null,
      currentPage: null
    }
  },
  computed: {
    ...mapGetters([
      'getterAccount',
      'getterCurrentSector'
    ])
  },
  mounted: function () {
    let page = this.$router.history.current.name
    this.userName = this.getterAccount.currentUser.nome
    this.userSector = this.getterCurrentSector.currentSector.nome
    if (page !== 'Pagina Inicial') {
      this.currentPage = page
    }
  },
  methods: {
    ...mapMutations([
      'LOGOUT_SERVICE'
    ]),
    logout () {
      setTimeout(() => {
        this.LOGOUT_SERVICE()
        this.$router.push('/login')
      }, 500)
    }
  }
}
