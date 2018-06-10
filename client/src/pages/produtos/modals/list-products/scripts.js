import { mapGetters } from 'vuex'
export default {
  data () {
    return {
      moreInfo: null,
      crt: false,
      war: false,
      ok: false
    }
  },
  computed: {
    ...mapGetters([
      'getterAllProducts'
    ])
  },
  mounted: function () {

  },
  methods: {
    showInfo (item) {
      if (!this.moreInfo) {
        this.moreInfo = item.idProduct
      } else {
        this.moreInfo = null
      }
    }
  }
}
