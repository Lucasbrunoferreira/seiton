<template>
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
        <v-form v-model="valid" ref="form" lazy-validation >
          <v-text-field app-font
            label="Usuário"
            :rules="userRules"
            v-model="user">
          </v-text-field>
          <v-text-field
            label="Senha"
            v-model="pass"
            :rules="pasRules">
          </v-text-field>
          <div class="submit">
            <v-btn large @click="submit" :disabled="!valid" style="background-color: #6BD8D1">
              Entrar
            </v-btn>
          </div>
        </v-form>
      </div>
    </div>
    <div class="borda-direita back-escuro"></div>
  </div>
</template>

<script>
export default {
  name: 'PageLogin',
  data () {
    return {
      valid: true,
      user: '',
      pass: '',
      userRules: [
        v => !!v || 'Usuário Obrigatório!'
      ],
      pasRules: [
        v => !!v || 'Senha Obrigatória!'
      ]
    }
  },
  methods: {
    submit () {
      if (this.$refs.form.validate()) {
        alert("Usuario:  " + this.user + "     Senha:  " + this.pass)
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
  padding-top: 130px;
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
  color: #fff;
}
label {
  font-family: "Source Sans Pro" !important
}
input {
  width: 350px !important;
  border-bottom: 1px solid rgba(77, 79, 92, 0.377);
}
</style>
