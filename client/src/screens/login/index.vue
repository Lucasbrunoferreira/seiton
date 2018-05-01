<template>
  <v-app>
    <div class="page-container">
      <div class="content-logo">
        <div class="logo">
         <img src="static/img/logo.png">
        </div>
      </div>
      <div class="content-login">
        <div class="titulo login-item">
          Bem Vindo!
        </div>
        <div class="msg-login login-item">
          Por favor faça login com sua conta:
        </div>
        <div class="form-login login-item">
          <v-form ref="form">
            <v-text-field
              label="Usuário"
              v-model="user">
            </v-text-field>
            <v-text-field
              type="password"
              label="Senha"
              v-model="pass">
            </v-text-field>
            <v-alert outline color="success" icon="check_circle" v-if="sucessSubmit" :value="true">
              Sucesso! Aguarde...
            </v-alert>
            <v-alert v-if="erroSubmit" outline color="error" icon="warning" :value="true">
              Por favor, preencha todos os campos!
            </v-alert>
            <v-alert v-if="invalidSubmit" outline color="error" icon="warning" :value="true">
              Usuário ou Senha inválido(s)!
            </v-alert>
            <div class="submit">
              <v-btn class="primary" large @click="submit">
                <b>Entrar</b>
              </v-btn>
            </div>
          </v-form>
        </div>
      </div>
      <div class="left-border"></div>
    </div>
  </v-app>
</template>

<script src="./scripts"></script>

<style lang="css" src="../../css/login.css"></style>
