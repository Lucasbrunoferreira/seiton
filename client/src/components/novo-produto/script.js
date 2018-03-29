import axios from 'axios'

export default {
  name: 'novo-produto',
  data () {
    return {
      posts: [],
      errors: []
    }
  },

  created () {
    axios.get('url a ser consumida')
      .then(response => {
        // tratar resposta
        this.posts = response.data
      })
      .catch(e => {
        // tratar erro
        this.errors.push(e)
      })
  }
}
