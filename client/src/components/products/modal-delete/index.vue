<template>
  <v-layout row justify-center>
    <v-dialog v-model="localStorage.openEditModal" persistent max-width="290">
      <v-card>
        <v-card-title class="headline">Deseja realmente deletar este item?</v-card-title>
        <v-card-actions>
          <v-spacer></v-spacer>
          <v-btn color="red darken-1" flat @click.native="dialog = false">CANCELAR</v-btn>
          <v-btn color="green darken-1" flat @click.native="dialog = false">DELETAR</v-btn>
        </v-card-actions>
      </v-card>
    </v-dialog>
  </v-layout>
</template>

<script src="./scripts.js"></script>
