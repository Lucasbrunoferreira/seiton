<template>
  <div class="page-container">
    <div class="content-logo back-escuro">
      <div class="logo">
       <img src="../../static/img/logo.png">
      </div>
    </div>
    <div class="content-login">
      <h3>direito</h3>
    </div>
    <div class="borda-direita back-escuro"></div>
  </div>
</template>

<script>
export default {
  name: 'PageLogin',
  data () {
    return {
    }
  }
}
</script>

<style>
html, body, #app{
    overflow: hidden;
    width: 100%;
    height:100%;
}
.page-container {
  display: flex;
  height: 100%;
}
.content-logo {
  display: flex;
  flex-grow: 3;
  align-items: center;
  justify-content: center;
}
.content-login {
  display: flex;
  flex-grow: 8;
  align-items: center;
  justify-content: center;
}
.borda-direita {
  width: 18px;
}
</style>
