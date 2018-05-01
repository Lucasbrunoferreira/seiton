<template>
  <div class="wrapper-products">
    <aside class="aside-content">
      <navigationDrawer></navigationDrawer>
    </aside>
    <div class="content">
      <headerBar class="header-content"></headerBar>
      <section class="main-content">
        <router-view></router-view>
      </section>
    </div>
  </div>
</template>

<style lang="css" src="../../css/home.css"></style>

<script src="./scripts"></script>
