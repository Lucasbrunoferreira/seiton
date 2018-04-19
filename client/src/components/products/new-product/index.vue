<template>
  <div class="newProducts-container">
    <h1>Novo Produto</h1>
    <v-form v-model="valid" ref="form" lazy-validation>
        <v-text-field
          label="Descrição do Produto"
          v-model="name"
          :rules="nameRules"
          :counter="60"
          required
        ></v-text-field>
        <v-text-field
          label="Código de Barras"
          v-model="codBarras"
          :counter="20"
          :rules="codBarrasRules"
          required
        ></v-text-field>
        <v-select
          label="Item"
          v-model="select"
          :items="items"
          :rules="[v => !!v || 'Item is required']"
          required
        ></v-select>

        <div class="btns-">
          <v-btn
            @click.native="submit"
            :disabled="!valid"
          >
            submit
          </v-btn>
          <v-btn @click.native="clear()">clear</v-btn>
        </div>
      </v-form>
  </div>
</template>

<script src="./scripts.js"></script>
