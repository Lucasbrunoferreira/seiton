<template>
  <div class="main-content">
      <h1>Clientes</h1>

    <div class="content-products">
      <table class="products-table">
        <v-card>
            <v-card-title>
              <v-text-field
                append-icon="search"
                label="Buscar Produto"
                single-line
                hide-details
                v-model="search"
              ></v-text-field>
            </v-card-title>
            <v-data-table
              :headers="headers"
              :items="items"
              :search="search"
            >
              <template slot="items" slot-scope="props" class="product-hover" @click="ola()">
                <td>{{ props.item.nome }}</td>
                <td class="text-xs-right">{{ props.item.codigoBarra }}</td>
                <td class="text-xs-right">{{ props.item.estoque }}</td>
                <td class="text-xs-right">R$&emsp;{{ props.item.precoCompra }}</td>
                <td class="text-xs-right">R$&emsp;{{ props.item.precoVenda }}</td>
                <td class="text-xs-right">{{ props.item.desconto }}%</td>
              </template>
              <v-alert slot="no-results" :value="true" outline color="error" icon="warning">
                Não foi encontado "{{ search }}" na lista de produtos.
              </v-alert>
            </v-data-table>
          </v-card>
        </table>

      <span>
        <ul class="btns-produtcts">
          <li>
            <v-btn large icon to="/produtos/novo" color="primary">
              <img src="/static/icons/new.png" style="width: 25px">
            </v-btn>
            </li>
          <li>
            <v-btn large icon to="/produtos/novo" color="primary">
              <img src="/static/icons/edit.png" style="width: 25px">
            </v-btn>
          </li>
          <li>
            <v-btn large icon to="/produtos/novo" color="primary">
              <img src="/static/icons/delete.png" style="width: 25px">
            </v-btn>
          </li>
        </ul>
      </span>
    </div>
  </div>
</template>

<script src="./scripts.js"></script>

<style src="../../css/clients.css"></style>
