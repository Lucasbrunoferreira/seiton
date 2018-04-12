<template>
 <v-expansion-panel popout>
    <v-expansion-panel-content v-for="(item,i) in 5" :key="i">
      <div slot="header">Item</div>
      <v-card>
        <v-card-text>Lorem ipsum dolor sit amet, consectetur a</v-card-text>
      </v-card>
    </v-expansion-panel-content>
  </v-expansion-panel>
</template>
