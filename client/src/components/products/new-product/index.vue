<template>
  <div class="newProducts-container">
    <h1>{{ titulo }}</h1>
    <v-form v-model="valid" ref="form" lazy-validation>
        <v-text-field
          label="Descrição do Produto"
          v-model="descricao"
          :rules="descricaoRules"
          :counter="60"
          required
        ></v-text-field>

        <v-text-field
          label="Código de Barras"
          v-model="codBarras"
          :counter="20"
          :rules="codBarrasRules"
          required
          type="number"
        ></v-text-field>

        <v-select
          :items="items"
          v-model="linha"
          label="Segmento"
          single-line
          required
        ></v-select>

        <v-text-field
          label="Data de Validade"
          v-model="dataValidade"
          :rules="dtValRules"
          required
          type="date"
        ></v-text-field>

        <v-text-field
          label="Preço de Compra"
          v-model="precoCompra"
          :rules="prCompraRules"
          required
          type="number"
          prefix="$"
        ></v-text-field>

        <v-text-field
          label="Preço de Venda"
          v-model="precoVenda"
          :rules="prVendaRules"
          required
          type="number"
          prefix="$"
        ></v-text-field>

        <v-text-field
          label="Desconto"
          v-model="desconto"
          :rules="descontoRules"
          required
          type="number"
          prefix="%"
        ></v-text-field>

        <v-text-field
          label="ICMS"
          v-model="icms"
          :rules="icmsRules"
          required
          type="number"
          prefix="%"
        ></v-text-field>

        <v-select
          :items="providers"
          v-model="fornecedor"
          label="Fornecedor"
          single-line
          required
        ></v-select>

        <div>
          <v-btn
            @click.native="submit"
            :disabled="!valid"
            color="primary"
          >
            SALVAR
          </v-btn>
          <v-btn @click.native="clear()">Limpar</v-btn>
          <v-btn @click.native="cancelar()">VOLTAR</v-btn>
        </div>
      </v-form>
      <v-snackbar
        :timeout="timeout"
        :top="y"
        :bottom="y"
        :right="x"
        :left="x"
        :multi-line="mode === 'multi-line'"
        :vertical="mode === 'vertical'"
        v-model="snackbar"
        :color="color"
      >
        {{ text }}
        <v-btn flat color="white" @click.native="snackbar = false">OK</v-btn>
      </v-snackbar>
  </div>
</template>

<script src="./scripts.js"></script>

<style src="../../../css/new-product.css"></style>
