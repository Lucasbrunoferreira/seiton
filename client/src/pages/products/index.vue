<template>
  <section class="products-page">
    <headerBar></headerBar>

    <section class="products-wrapper">
      <div class="content-products">
        <listProducts></listProducts>
      </div>

      <div class="info-products">
        <pieChart></pieChart>
        <ul class="rank">
          <h4>Rank de Produtos</h4>
          <li>
            <img src="/static/assets/icons/first.svg">
            <span>Losarantana Potassica</span>
          </li>

          <li>
            <img src="/static/assets/icons/second.svg">
            <span>Meloxicam 15mg</span>
          </li>

          <li>
            <img src="/static/assets/icons/third.svg">
            <span>Clonazepam 3mg</span>
          </li>
        </ul>
      </div>

      <button class="new-product">
        <img src="/static/assets/icons/add.svg">
      </button>
    </section>
  </section>
</template>

<script src="./scripts"></script>
