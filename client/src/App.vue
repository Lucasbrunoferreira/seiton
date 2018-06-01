<template>
  <router-view/>
</template>

<script>
import { mapGetters } from 'vuex'

export default {
  computed: {
    ...mapGetters([
      'getterAccount'
    ])
  }
}
</script>

<style lang="scss">
  @import './style/style.scss';
</style>
