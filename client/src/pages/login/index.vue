<template>
  <div class="login-page">
    <section class="login-container">
      <div class="logo">
        <img src="/static/assets/images/logo.png">
      </div>
      <div class="login-form">
        <form action="#">
          <div class="login-input">
            <img src="/static/assets/icons/user.png">
            <input required type="text" placeholder="usuario" class="valid-input">
          </div>

          <div class="login-input">
            <img src="/static/assets/icons/password.png">
            <input required type="password" placeholder="senha" class="valid-input">
          </div>
          <button type="submit">login</button>
        </form>
      </div>

      <div class="bar-colored"></div>
    </section>
  </div>
</template>

<script src="./scripts"></script>
