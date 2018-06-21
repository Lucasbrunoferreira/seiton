<template>
  <div class="login-page">
    <section class="login-container">

      <div class="logo">
        <img src="/static/assets/images/logo.png">
      </div>

      <div class="login-form">
        <form v-on:submit.prevent>
          <div class="login-input">
            <img src="/static/assets/icons/user.svg">
            <input v-model="usuario" required type="text" placeholder="usuario" class="valid-input">
          </div>

          <div class="login-input">
            <img src="/static/assets/icons/password.svg">
            <input v-model="senha" required type="password" placeholder="senha" class="valid-input">
          </div>
          <button @click="login()" type="submit">login</button>
        </form>
      </div>

      <div class="bar-colored"></div>
    </section>
  </div>
</template>

<script src="./scripts"></script>
