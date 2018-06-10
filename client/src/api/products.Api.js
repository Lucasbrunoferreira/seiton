import Const from '../helpers/const'
import axios from 'axios'

export default {
  getAllProducts () {
    return axios.get(`${Const.PRODUCTS}`)
  }
}
