<template>
  <div class="hello">
    <h1>{{ msg }}</h1> <br> <br>
    <v-layout>
      <v-flex offset-xs4 xs1>
          <v-btn outline large fab color="indigo" to="/produtos/lista">
            <v-icon>list</v-icon>
          </v-btn>
      </v-flex>
      <v-flex xs2>
        <v-btn outline large fab color="green" to="/produtos/novo">
          <v-icon>add</v-icon>
          <template>

    <v-btn color="success">Success</v-btn>
    <v-btn color="error">Error</v-btn>
    <v-btn color="warning">Warning</v-btn>
    <v-btn color="info">Info</v-btn>
  

        </v-btn>
      </v-flex>
      <v-flex xs1>
        <v-btn outline large fab color="red" to="/produtos/excluir">
          <v-icon>remove</v-icon>
        </v-btn>
      </v-flex>
    </v-layout>
  </div>
</template>

<script>
export default {
  name: 'PageProdutos',
  data () {
    return {
      msg: 'Meus Produtos'
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h1, h2 {
  font-weight: normal;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
