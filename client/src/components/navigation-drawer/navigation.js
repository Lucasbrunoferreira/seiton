export default {
  name: 'navigationDrawer',
  data () {
    return {
      drawer: true,
      items: [{
        title: 'Home',
        icon: 'dashboard'
      },
      {
        title: 'About',
        icon: 'question_answer'
      }],
      mini: true,
      right: null
    }
  },
  methods: {
    ola () {
      this.$router.push('/')
    }
  }
}
