<template>
  <div>
  <h1>Lista de Produtos</h1> <br><br>
  <ul v-for="product of products" :key="product.id">
    <li> <b>ID:</b> &ensp; {{product.id}} </li>
    <li> <b>Nome:</b> &ensp; {{ product.nome }} </li>
    <li> <b>Estoque</b> &ensp; {{ product.estoque }} </li>
    <li> <b>Preço de Venda:</b> &ensp; R${{ product.precoVenda }} </li>
    <li> <b> Data de cadastro: </b> &ensp; {{ product.dataCastro }} </li>
    <br><br>
  </ul>
  </div>
</template>

<style >
</style>

<script src="./script"></script>
