import Const from '../helpers/const'
import axios from 'axios'

export default {
  signIn (usuario, senha) {
    return axios.post(`${Const.LOGIN}`, {
      usuario,
      senha
    })
  },
  getAllUsers () {
    return axios.get(`${Const.USERS}`)
  },
  deleteUser (idContribuitor) {
    return axios.delete(`${Const.USERS}/${idContribuitor}`)
  },
  createUser (user) {
    return axios.post(`${Const.USERS}`, user)
  },
  editUser (user) {
    return axios.put(`${Const.USERS}/${user.idContribuitor}`, user)
  }
}
