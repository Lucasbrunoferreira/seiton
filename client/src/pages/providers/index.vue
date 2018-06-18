<template>
  <div class="providers-page">
    <headerBar></headerBar>

    <div class="search">
      <img src="/static/assets/icons/search.svg">
      <input type="text" class="search" v-model="search"/>
    </div>

    <section class="providers-wrapper">
      <ul class="providers-list">
        <li>
          <div class="provider-info">
            <span class="name">Distribuidora Sagáz Arghany</span>
          </div>

          <div class="provider-content">
            <div>
              <img src="/static/assets/icons/profile.svg">
              <span>Lucas Bruno</span>
            </div>
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>Patos de Minas</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>34996753911</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>lucasbrunoferreira@gmail.com</span>
            </div>
          </div>
        </li>

      </ul>
    </section>

    <button class="new-product">
      <img src="/static/assets/icons/add.svg">
    </button>
  </div>
</template>

<script src="./scripts"></script>
