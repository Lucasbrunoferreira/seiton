<template>
  <div class="products-wrapper">
    <h1>Produtos</h1>

    <ul class="fast-view">
      <li><img src="/static/icons/total_produtos.svg"> <span class="qtdFast">{{ totalItems }}</span> Total de Produtos</li>
      <li><img src="/static/icons/goal.svg"> <span class="qtdFast">9</span> Alta Sazonalidade</li>
      <li><img src="/static/icons/caution-sign.svg"> <span class="qtdFast">3</span> Produtos em Risco</li>
    </ul>

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
              <template slot="items" slot-scope="props" class="product-hover">
                <td>{{ props.item.nome }}</td>
                <td class="text-xs-right">{{ props.item.codigoBarra }}</td>
                <td class="text-xs-right">{{ props.item.estoque }}</td>
                <td class="text-xs-right">R$&emsp;{{ props.item.precoCompra }}</td>
                <td class="text-xs-right">R$&emsp;{{ props.item.precoVenda }}</td>
                <td class="text-xs-right">{{ props.item.desconto }}%</td>
                <td class="text-xs-right">
                  <a href="#">
                    <v-icon class="listOptions" color="blue-grey lighten-2" @click="itemEdit(props.item)">edit</v-icon>
                  </a>
                </td>
                <td class="text-xs-right">
                  <a href="#">
                    <v-icon class="listOptions" color="red lighten-2" @click="openDelete(props.item.idProduct)">delete</v-icon>
                  </a>
                </td>
              </template>
              <v-alert slot="no-results" :value="true" outline color="error" icon="warning">
                Não foi encontado "{{ search }}" na lista de produtos.
              </v-alert>
            </v-data-table>
          </v-card>
        </table>

      <span>
        <table class="analityc-table" >
          <img src="/static/img/analise.png">
        </table>
        <ul class="btns-produtcts">
          <li>
            <v-btn large icon to="/produtos/novo" color="primary">
              <img src="/static/icons/new.png" style="width: 25px">
            </v-btn>
          </li>
        </ul>
      </span>
    </div>
    <v-layout row justify-center>
      <v-dialog v-model="isOpen" persistent max-width="290">
        <v-card>
          <v-card-title class="headline">Deseja realmente deletar este item?</v-card-title>
          <v-card-actions>
            <v-spacer></v-spacer>
            <v-btn color="red darken-1" flat @click.native="isOpen = false">CANCELAR</v-btn>
            <v-btn color="green darken-1" flat @click="itemDelete()">DELETAR</v-btn>
          </v-card-actions>
        </v-card>
      </v-dialog>
    </v-layout>
    <v-snackbar
      :timeout="timeout"
      :color="color"
      :multi-line="mode === 'multi-line'"
      :vertical="mode === 'vertical'"
      v-model="snackbar"
    >
      {{ text }}
      <v-btn dark flat @click.native="snackbar = false">Close</v-btn>
    </v-snackbar>
  </div>
</template>

<script src="./scripts.js"></script>

<style src="../../css/products.css"> </style>
