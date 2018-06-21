import Const from '../helpers/const'
import axios from 'axios'

export default {
  getAllLines () {
    return axios.get(`${Const.LINES}`)
  }
}
