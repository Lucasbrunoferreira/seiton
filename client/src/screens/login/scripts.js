export default {
  name: 'PageLogin',
  data () {
    return {
      user: '',
      pass: '',
      erroSubmit: false,
      sucessSubmit: false,
      invalidSubmit: false
    }
  },
  methods: {
    submit () {
      if (this.user && this.pass) {
        if (this.user === 'admin' && this.pass === 'admin') {
          this.sucessSubmit = true
          setTimeout(() => {
            this.$router.push('produtos')
          }, 3500)
        } else {
          this.invalidSubmit = true
          setTimeout(() => {
            this.invalidSubmit = false
          }, 3500)
        }
      } else {
        this.erroSubmit = true
        setTimeout(() => {
          this.erroSubmit = false
        }, 3500)
      }
    }
  }
}
