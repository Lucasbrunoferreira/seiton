import Const from '../helpers/const'
import axios from 'axios'

export default {
  signIn (usuario, senha) {
    return axios.post(`${Const.LOGIN}`, {
      usuario,
      senha
    })
  }
}
