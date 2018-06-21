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
    return axios.post(`${Const.PRODUCTS}`, product)
  },
  editProduct (product) {
    return axios.put(`${Const.PRODUCTS}/${product.id}`, product)
  }

}
