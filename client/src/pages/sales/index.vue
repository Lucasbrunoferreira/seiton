<template>
  <div class="sales-page">
    <span class="no-print header">
      <headerBar></headerBar>
    </span>

    <section class="wrapper">
      <div class="sale-content">
       <div class="header">
          <div>
           <span>Cliente</span>
           <select class="valid-select" v-model="selectedClient">
             <option v-for="(client, index) in getterAllClients" :key="index" :value="`${client.idClient}`"> {{ client.nomeRazaoSocial }} </option>
           </select>
          </div>

         <div>
           <span>Colaborador:</span>
            <select class="valid-select" v-if="getterAccount.idSector === 1" v-model="selectedContribuitor">
             <option v-for="(user, index) in getterAllUsers" :key="index" :value="`${user.idContribuitor}`"> {{ user.nome }} </option>
           </select>
           <span v-tooltip.bottom-start="'Você pode realizar vendas apenas para você mesmo!'" v-else>
           <select class="valid-select" v-model="selectedContribuitor">
              <option :value="`${ getterAccount.idContribuitor }`" >{{ getterAccount.nome }}</option>
           </select>
           </span>
         </div>
       </div>

      <div class="add no-print">
        <select class="valid-select" v-model="selectedProduct">
          <option v-for="(product, index) in getterAllProducts" :key="index" :value="`${ product.idProduct }`"> {{ product.nome }}</option>
        </select>
        <input class="qtd" type="number" v-model="qtd">
        <button @click="addProduct">
          <img src="/static/assets/icons/add.svg">
        </button>
      </div>

      <div class="legend">
        <span>Index</span>
        <span>Produto</span>
        <span>Quantidade</span>
        <span>Valor Unitario</span>
        <span>Total</span>
      </div>

      <ul class="sales-products">
        <li v-for="(product, index) in getterSale" :key="index">
          <span>{{ getterSale.indexOf(product) }}</span>
          <span>{{ product.product }}</span>
          <span>{{ product.qtd }}</span>
          <span>R$ {{ product.valor }}</span>
          <span>R$ {{ product.valor * product.qtd }}</span>
          <img src="/static/assets/icons/cancel.svg" @click="remover(product)">
        </li>
      </ul>

      </div>

      <div class="manager-sale no-print">
        <div class="total no-print" v-if="getterSale">
          <span>Total de Produtos</span>
          <b class="qtd no-print">{{ getterSale.length }}</b>
        </div>

        <div class="manager-saler">
          <button class="confirm no-print" @click="imprimir()">Imprimir</button>
        </div>
      </div>
    </section>

  </div>
</template>

<script src="./scripts"></script>
