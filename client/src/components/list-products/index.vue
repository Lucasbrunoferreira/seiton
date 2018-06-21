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

          <span class="estoque" @click="showInfo(product)"> {{ product.estoque }} </span>

          <div class="btns-manager" v-if="moreInfo == product.idProduct">

            <button @click="openDelete(product.idProduct)">
              <img src="/static/assets/icons/delete.svg">
            </button>

            <button @click="editProduct(product)">
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

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="editedSuccess">
      <span>O Produto foi editado com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="warning" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="deletedError">
      <span>Houve algum erro durante o processo!</span>
    </sweet-modal>

    <sweet-modal overlay-theme="dark" blocking modal-theme="dark" ref="editProduct" class="edit">
        <h3>Editar Produto</h3>
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
          <button class="confirm" @click="salveProduct()">Criar</button>
          <button class="cancel" @click="close()">Voltar</button>
        </div>
    </sweet-modal>
  </ul>
</template>

<script src="./scripts"></script>
