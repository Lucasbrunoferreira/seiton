import Const from '../helpers/const'
import axios from 'axios'

export default {
  getAllProviders () {
    return axios.get(`${Const.PROVIDERS}`)
  },
  deleteProvider (idProvider) {
    return axios.delete(`${Const.PROVIDERS}/${idProvider}`)
  },
  createProvider (provider) {
    return axios.post(`${Const.PROVIDERS}`, provider)
  },
  editProvider (provider) {
    return axios.put(`${Const.PROVIDERS}/${provider.idProvider}`, provider)
  }

}
