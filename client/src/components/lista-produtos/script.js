import axios from 'axios'

export default {
  name: 'lista-produto',
  data () {
    return {
      products: [],
      errors: []
    }
  },

  created () {
    axios.get('http://localhost:52667/api/product')
      .then(response => {
        this.products = response.data
        console.log(response.data)
      })
      .catch(e => {
        this.errors.push(e)
        console.log(e)
      })
  }
}
