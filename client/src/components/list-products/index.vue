<template>
  <ul class="list-products" >
    <div class="options-list">

      <div class="filter">
        <img src="/static/assets/icons/filter.svg">
        <select class="line" v-model="filteredLine">
          <option>Todos</option>
          <option v-for="(lines, index) in getterAllLines" :key="index">
            <span> {{lines.idLine}} </span>
            <span> {{ lines.nome }} </span>
          </option>
        </select>
      </div>

      <div class="search">
        <img src="/static/assets/icons/search.svg">
        <input type="text" class="search" v-model="search"/>
      </div>
    </div>

    <div class="list">
      <span  v-for="(product, index) in filteredProducts" :key="index">
        <li>
          <span v-bind:class="{
            'critical': product.estoque < 100,
            'warning': product.estoque >= 100 && product.estoque < 200,
            'normal' : product.estoque > 200 }">
            </span>

          <div class="info" @click="showInfo(product)">
            <span class="product-name">{{ product.nome }}</span>
            <span class="value">R$ {{ product.precoVenda }}</span>
          </div>

          <div class="btns-manager">
            <span @click="showInfo(product)"> {{ product.estoque }} </span>

            <button @click="openDelete(product.idProduct)">
              <img src="/static/assets/icons/delete.svg">
            </button>

            <button>
              <img src="/static/assets/icons/edit.svg">
            </button>

          </div>
        </li>

        <div class="more-info" v-if="moreInfo == product.idProduct">
          <span> <b>Compra:</b> R$ {{ product.precoCompra }}</span>

          <span> <b>Cod. Barra:</b>{{product.codigoBarra }}</span>

          <span> <b>Lote:</b> {{ product.lote }}</span>

          <span> <b>Desconto:</b> {{ product.desconto }}%</span>

          <span> <b>ICMS:</b> {{ product.icms }}%</span>

          <span> <b>Validade:</b> {{ product.dataValidade }}</span>
        </div>
      </span>
    </div>

    <sweet-modal icon="error" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="delete">
      <span>Deseja realmente deletar este produto?</span>
      <div class="modal-btns">
        <button class="confirm" @click="confirmDelete()">Sim</button>
        <button class="cancel" @click="close()">Não</button>
      </div>
    </sweet-modal>

     <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="deletedSuccess">
      <span>O Produto foi deletado com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="warning" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="deletedError">
      <span>Houve algum erro durante o processo!</span>
      <button class="close" @click="close()">Ok</button>
    </sweet-modal>
  </ul>
</template>

<script src="./scripts"></script>
