<template>
  <v-app>
    <v-navigation-drawer stateless hide-overlay :mini-variant.sync="mini" v-model="drawer">
      <v-toolbar flat class="transparent">
        <v-list class="pa-0">
          <v-list-tile >
            <v-list-tile-avatar>
              <img src="/static/img/top_logo.png" >
            </v-list-tile-avatar>
            <v-list-tile-content>
              <v-list-tile-title>Lucas</v-list-tile-title>
            </v-list-tile-content>
          </v-list-tile>
        </v-list>
      </v-toolbar>
      <v-list class="pt-2" dense>
        <v-divider></v-divider>
        <v-list-tile v-for="item in items" :key="item.title" class="pt-3" :to="item.route">
          <v-list-tile-action>
            <img class="nav-icon" :src="item.icon">
          </v-list-tile-action>
          <v-list-tile-content>
            <v-list-tile-title>{{ item.title }}</v-list-tile-title>
          </v-list-tile-content>
        </v-list-tile>
        <v-list-tile-action class="pt-4">
          <v-btn flat  @click.native.stop="mini = !mini">
            <v-icon>code</v-icon>
          </v-btn>
        </v-list-tile-action>
      </v-list>
    </v-navigation-drawer>
  </v-app>
</template>

<script src="./scripts.js"></script>
