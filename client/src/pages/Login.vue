<template>
  <v-app>
    <div class="page-container">
      <div class="content-logo back-escuro">
        <div class="logo">
        <img src="../../static/img/logo.png" style="height: 140px; width: 380px">
        </div>
      </div>
      <div class="content-login">
        <div class="titulo login-item primaria cursiva">
          Bem Vindo!
        </div>
        <div class="msg-login login-item terciaria app-font">
          Por favor faça login com sua conta:
        </div>
        <div class="form-login login-item">
          <v-form ref="form">
            <v-text-field app-font
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
              <v-btn large @click="submit" style="background-color: #6BD8D1">
                <b>Entrar</b>
              </v-btn>
            </div>
          </v-form>
        </div>
      </div>
      <div class="borda-direita back-escuro"></div>
    </div>
  </v-app>
</template>

<script>
export default {
  name: 'PageLogin',
  data () {
    return {
      user: '',
      pass: '',
      erroSubmit: false,
      sucessSubmit: false,
      invalidSubmit: false
    }
  },
  methods: {
    submit () {
      if (this.user && this.pass) {
        if (this.user === 'admin' && this.pass === 'admin') {
          this.sucessSubmit = true
          setTimeout(() => {
            this.$router.push('produtos')
          }, 3500)
        } else {
          this.invalidSubmit = true
          setTimeout(() => {
            this.invalidSubmit = false
          }, 3500)
        }
      } else {
        this.erroSubmit = true
        setTimeout(() => {
          this.erroSubmit = false
        }, 3500)
      }
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
  flex-grow: 6;
  align-items: center;
  justify-content: center;
}
.content-login {
  flex-grow: 6;
}
.borda-direita {
  width: 20px;
}
.login-item {
  display: flex;
  align-items: center;
  justify-content: center;
}
.titulo {
  padding-top: 110px;
  font-size: 40px;
}
.msg-login {
  font-size: 16px;
  padding: 40px 0px 60px 0px;
}
.submit {
  padding-top: 50px;
  display: flex;
  align-items: center;
  justify-content: center;
  font-family: "Source Sans Pro" !important;
}
label {
  font-family: "Source Sans Pro" !important
}
input {
  width: 350px !important;
  border-bottom: 1px solid rgba(77, 79, 92, 0.377);
}
</style>
