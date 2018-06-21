import Const from '../helpers/const'
import axios from 'axios'

export default {
  getAllSectors () {
    return axios.get(`${Const.SECTOR}`)
  },
  getCurrentSector (idSector) {
    return axios.get(`${Const.SECTOR}/${idSector}`)
  }
}
