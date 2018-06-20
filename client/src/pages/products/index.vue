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

      <button class="new-product" @click="openNewProduct">
        <img src="/static/assets/icons/add.svg">
      </button>

      <sweet-modal overlay-theme="dark" modal-theme="dark" ref="newProduct" class="newProduct-modal">
        <h3>Criar novo Produto</h3>
        <section class="wrapper">
          <div>
            <label for="nome">Nome</label>
            <input required class="valid-input" v-model="productName" type="text" id="nome">
          </div>

          <div>
            <label for="cod">Cod. Barras</label>
            <input required class="valid-input" v-model="productCod" type="text" id="cod">
          </div>

          <div>
            <label for="lote">Lote</label>
            <input required class="valid-input" v-model="productLote" type="text" id="lote">
          </div>

          <div>
            <label for="estoque">Estoque</label>
            <input required class="valid-input" v-model="productEst" type="text" id="estoque">
          </div>

          <div>
            <label for="dtVal">Data Validade</label>
            <input required class="valid-input" v-model="productValid" type="date" id="dtVal">
          </div>

          <div>
            <label for="compra">Preço de Compra</label>
            <input required class="valid-input" v-model="productBuy" min="0.00" max="10000.00" step="0.01"  type="number" id="compra">
          </div>

          <div>
            <label for="venda">Preço Venda</label>
            <input required class="valid-input" v-model="productSell" min="0.00" max="10000.00" step="0.01" type="number" id="venda">
          </div>

          <div>
            <label for="desc">Desconto</label>
            <input required class="valid-input" v-model="productDesc" min="0.00" max="10000.00" step="0.01" type="number" id="desc">
          </div>

          <div>
            <label for="icms">ICMS</label>
            <input required class="valid-input" v-model="productICMS" min="0.00" max="10000.00" step="0.01" type="number" id="icms">
          </div>

          <div>
            <label for="venda">Linha</label>
            <select required class="valid-select" v-model="idLine">
              <option v-for="(line, index) in getterAllLines" :key="index" :value="`${line.idLine}`">{{ line.nome }}</option>
            </select>
          </div>

          <div>
            <label for="venda">Fornecedor</label>
            <select required class="valid-select" v-model="idProvider">
              <option v-for="(provider, index) in getterAllProviders" :key="index" :value="`${provider.idProvider}`">{{ provider.nome }}</option>
            </select>
          </div>
        </section>

        <div class="modal-btns">
          <button class="confirm" @click="createProduct()">Criar</button>
          <button class="cancel" @click="close()">Voltar</button>
        </div>
    </sweet-modal>
    </section>
  </section>
</template>

<script src="./scripts"></script>
