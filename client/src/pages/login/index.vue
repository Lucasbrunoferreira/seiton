<template>
  <div class="login-page">
    <section class="login-container">
      <div class="logo">
        <img src="/static/assets/images/logo.png">
      </div>
      <div class="login-form">
        <form action="">
          <div class="login-input">
            <img src="/static/assets/icons/user.png">
            <input type="text" placeholder="usuario">
          </div>

          <div class="login-input">
            <img src="/static/assets/icons/password.png">
            <input type="password" placeholder="senha">
          </div>
          <button>login</button>
        </form>
      </div>

      <div class="bar-colored"></div>
    </section>
  </div>
</template>

<script src="./scripts"></script>

<style lang="scss">
    @import '../../style/style.scss';
</style>
