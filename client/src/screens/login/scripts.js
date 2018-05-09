import Firebase from 'firebase'

export default {
  name: 'PageLogin',
  data () {
    return {
      pass: '',
      email: '',
      erroSubmit: false,
      sucessSubmit: false,
      invalidSubmit: false
    }
  },
  methods: {
    Login: function (event) {
      const auth = Firebase.auth()
      const promise = auth.signInWithEmailAndPassword(this.email, this.pass).then(user => {
        window.localStorage.setItem('idUser', user.uid)
        window.localStorage.setItem('userEmail', user.email)
        this.sucessSubmit = true
        setTimeout(() => {
          this.$router.push('produtos')
        }, 3500)
      }).catch(error => {
        console.warn(error)
        this.invalidSubmit = true
        setTimeout(() => {
          this.invalidSubmit = false
        }, 3500)
      })
      promise.catch(event => console.log(event.message))
    }
  }
}
