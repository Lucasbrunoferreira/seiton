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
    this.currentPage = this.$router.history.current.name
    this.userName = this.getterAccount.nome
    this.userSector = this.getterCurrentSector.nome
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
    },
    returnHome () {
      this.$router.push('/home')
    }
  }
}
