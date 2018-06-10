<template>
  <div class="home-page">
    <headerBar></headerBar>
    <ul class="main-menu">
      <li>
        <button @click="toPage('/produtos')">
          <img src="/static/assets/icons/produtos.svg">
          <span>Produtos</span>
        </button>
      </li>
      <li>
        <button @click="toPage('/clientes')">
          <img src="/static/assets/icons/clientes.svg">
          <span>Clientes</span>
        </button>
      </li>
      <li>
        <button @click="toPage('/fornecedores')">
          <img src="/static/assets/icons/fornecedores.svg">
          <span>Fornecedores</span>
        </button>
      </li>
      <li>
        <button @click="toPage('/colaboradores')">
          <img src="/static/assets/icons/colaboradores.svg">
          <span>Colaboradores</span>
        </button>
      </li>
      <li>
        <button @click="toPage('/venda')">
          <img src="/static/assets/icons/venda.svg">
          <span>Gerar venda</span>
        </button>
      </li>
    </ul>
    <div class="charts">
      <chartLine></chartLine>
      <chartBar></chartBar>
      </div>
  </div>
</template>

<script src="./scripts"></script>
