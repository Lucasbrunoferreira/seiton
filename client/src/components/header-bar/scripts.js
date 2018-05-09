export default {
  data () {
    return {
      email: ''
    }
  },
  created: function () {
    this.email = localStorage.userEmail
  }
}
