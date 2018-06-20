<template>
  <div class="sales-page">
    <headerBar></headerBar>

    <section class="wrapper">
      <div class="sale-content">
       <div class="header">
          <div>
           <span>Cliente</span>
           <input type="text">
          </div>

         <div>
           <span>Colaborador:</span>
           <input type="text">
         </div>
       </div>

      <div class="add">
        <input class="search" type="text" placeholder="Buscar Produto">
        <input class="qtd" type="number">
        <button>
          <img src="/static/assets/icons/add.svg">
        </button>
      </div>

      <div class="legend">
        <span>Index</span>
        <span>Produto</span>
        <span>Quantidade</span>
        <span>Valor Unitario</span>
        <span>Total</span>
      </div>

      <ul class="sales-products">
        <li>
          <span>1</span>
          <span>Losartana Potassica 50mg</span>
          <span>102</span>
          <span>R$ 1.37</span>
          <span>R$ 378</span>
          <!-- <img src="/static/assets/icons/cancel.svg"> -->
        </li>
      </ul>

      </div>

      <div class="manager-sale">

      </div>
    </section>

  </div>
</template>

<script src="./scripts"></script>
