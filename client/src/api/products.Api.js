import Const from '../helpers/const'
import axios from 'axios'

export default {
  getAllProducts () {
    return axios.get(`${Const.PRODUCTS}`)
  },
  deleteProduct (idProduct) {
    return axios.delete(`${Const.PRODUCTS}/${idProduct}`)
  },
  createProduct (product) {
    return axios.post(`${Const.PRODUCTS}`, {
      product
    })
  }

}
