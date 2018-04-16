<template>
  <div class="products-wrapper">
    <h1>Produtos</h1>
    <ul class="fast-view">
      <li><img src="../../../static/icons/total_produtos.svg"> <span class="qtdFast">3</span> Total de Produtos</li>
      <li><img src="../../../static/icons/goal.svg"> <span class="qtdFast">3</span> Alta Sazonalidade</li>
      <li><img src="../../../static/icons/caution-sign.svg"> <span class="qtdFast">3</span> Produtos em Risco</li>
    </ul>
    <div class="content">
      <table class="products-table">
        <ul v-for="product in products" :key="product.nome">
          <li>{{ product.nome --- product.precoVenda }}</li>
        </ul>
      </table>
      <span>
        <table class="analityc-table" >Analise</table>
        <ul class="btns-produtcts">
          <li>novo</li>
          <li>editar</li>
          <li>excluir</li>
        </ul>
      </span>
    </div>
  </div>
</template>

<script src="./scripts.js"></script>
