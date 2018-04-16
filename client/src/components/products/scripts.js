import axios from 'axios'

export default {
  data () {
    return {
    }
  },
  created () {
    axios.get(`http://localhost:58538/api/products`)
      .then(response => {
        this.products = response.data
        console.log(this.products)
      })
      .catch(e => {
        this.errors.push(e)
      })
  },
  computed: {
    pages () {
      if (this.pagination.rowsPerPage == null ||
        this.pagination.totalItems == null
      ) return 0
      return Math.ceil(this.pagination.totalItems / this.pagination.rowsPerPage)
    }
  }
}
