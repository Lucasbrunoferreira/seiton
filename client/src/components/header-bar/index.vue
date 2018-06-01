<template>
  <header class="header-bar">
    <section class="user-info">
      <img class="top-logo" src="/static/assets/images/top_logo.png">

      <div class="welcome">
        <span>Seja bem vindo, </span>
        <span>{{ userName }}</span>
      </div>
    </section>

    <strong class="page-title">{{ currentPage }}</strong>

    <section class="page-info">
      <span class="">{{ userSector }}</span>

      <button @click="logout()" class="logout" v-tooltip.bottom-start="'Sair'">
        <img src="/static/assets/icons/logout.svg">
      </button>
    </section>

  </header>
</template>

<script src="./scripts"></script>
