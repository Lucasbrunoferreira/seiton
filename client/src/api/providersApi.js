import Const from '../helpers/const'
import axios from 'axios'

export default {
  getAllProviders () {
    return axios.get(`${Const.PROVIDERS}`)
  },
  deleteProvider (idProduct) {
    return axios.delete(`${Const.PROVIDERS}/${idProduct}`)
  }

}
