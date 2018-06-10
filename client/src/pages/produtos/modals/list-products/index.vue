<template>
  <ul class="list-products" >
    <span  v-for="(item, index) in getterAllProducts" :key="index">
      <li>
        <span v-bind:class="{
          'critical': item.estoque < 100,
          'warning': item.estoque >= 100 && item.estoque < 200,
          'normal' : item.estoque > 200 }">
          </span>

        <div class="info" @click="showInfo(item)">
          <span class="product-name">{{ item.nome }}</span>
          <span class="value">R$ {{ item.precoVenda }}</span>
        </div>

        <div class="btns-manager">
          <span @click="showInfo(item)"> {{ item.estoque }} </span>

          <button>
            <img src="/static/assets/icons/delete.svg">
          </button>

          <button>
            <img src="/static/assets/icons/edit.svg">
          </button>

        </div>
      </li>

      <div class="more-info" v-if="moreInfo == item.idProduct">
        <span> <b>Compra:</b> R$ {{ item.precoCompra }}</span>

        <span> <b>Cod. Barra:</b>{{item.codigoBarra }}</span>

        <span> <b>Lote:</b> {{ item.lote }}</span>

        <span> <b>Desconto:</b> {{ item.desconto }}%</span>

        <span> <b>ICMS:</b> {{ item.icms }}%</span>

        <span> <b>Validade:</b> {{ item.dataValidade }}</span>
      </div>
    </span>

  </ul>
</template>

<script src="./scripts"></script>
