import Const from '../helpers/const'
import axios from 'axios'

export default {
  getAllClients () {
    return axios.get(`${Const.CLIENT}`)
  },
  deleteClient (idClient) {
    return axios.delete(`${Const.CLIENT}/${idClient}`)
  },
  createClient (client) {
    return axios.post(`${Const.CLIENT}`, client)
  },
  editClient (client) {
    return axios.put(`${Const.CLIENT}/${client.idClient}`, client)
  }

}
