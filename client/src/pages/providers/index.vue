<template>
  <div class="providers-page">
    <headerBar></headerBar>

    <div class="search">
      <img src="/static/assets/icons/search.svg">
      <input type="text" class="search" v-model="search"/>
    </div>

    <section class="providers-wrapper">
      <ul class="providers-list">
        <li v-for="(provider, index) in getterAllProviders" :key="index" @click="manager(provider)">
          <div class="provider-info">
            <span class="name">{{ provider.nome }}</span>
          </div>

          <div class="provider-content">
            <div>
              <img src="/static/assets/icons/profile.svg">
              <span>{{ provider.responsavel }}</span>
            </div>
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>{{ provider.cidade }}</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>{{ provider.telefone }}</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>{{ provider.email }}</span>
            </div>
          </div>

          <div class="btns-manager" v-if="isManager === provider.idProvider">
              <button @click="openDelete(provider)">
                <img src="/static/assets/icons/delete.svg">
              </button>

              <button @click="openEdit(provider)">
                <img src="/static/assets/icons/edit.svg">
              </button>
          </div>
        </li>

      </ul>
    </section>

    <button class="new-product" @click="openNewProvider">
      <img src="/static/assets/icons/add.svg">
    </button>

      <sweet-modal overlay-theme="dark" blocking modal-theme="dark" ref="newProvider" class="newProduct-modal">
        <h3>Criar novo Fornecedor</h3>
        <section class="wrapper">
          <div>
            <label for="nome">Nome</label>
            <input required class="valid-input" v-model="nome" type="text" id="nome">
          </div>

          <div>
            <label for="cnpj">CNPJ</label>
            <input required class="valid-input" v-model="cnpj" type="text" id="cnpj">
          </div>

          <div>
            <label for="cidade">Cidade</label>
            <input required class="valid-input" v-model="cidade" type="text" id="cidade">
          </div>

          <div>
            <label for="responsavel">Responsavél</label>
            <input required class="valid-input" v-model="responsavel" type="text" id="responsavel">
          </div>

          <div>
            <label for="telefone">Telefone</label>
            <input required class="valid-input" v-model="telefone" type="text" id="telefone">
          </div>

          <div>
            <label for="email">Email</label>
            <input required class="valid-input" v-model="email" type="email" id="email">
          </div>

        </section>

        <div class="modal-btns">
          <button class="confirm" @click="createProvider()">Criar</button>
          <button class="cancel" @click="close()">Voltar</button>
        </div>
    </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="creteSuccess">
      <span>O Fornecedor foi criado com Sucesso!</span>
    </sweet-modal>

   <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="editedSuccess">
      <span>O Fornecedor foi criado com Sucesso!</span>
   </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="deletedSuccess">
      <span>O Fornecedor foi deletado com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="warning" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="error">
      <span>Houve algum erro durante o processo!</span>
    </sweet-modal>

    <sweet-modal icon="error" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="delete">
      <span>Deseja realmente deletar este fornecedor?</span>
      <div class="modal-btns">
        <button class="confirm" @click="confirmDelete()">Sim</button>
        <button class="cancel" @click="close()">Não</button>
      </div>
    </sweet-modal>

      <sweet-modal overlay-theme="dark" blocking modal-theme="dark" ref="editProvider" class="newProduct-modal">
        <h3>Editar Fornecedor</h3>
        <section class="wrapper">
          <div>
            <label for="nome">Nome</label>
            <input required class="valid-input" v-model="nome" type="text" id="nome">
          </div>

          <div>
            <label for="cnpj">CNPJ</label>
            <input required class="valid-input" v-model="cnpj" type="text" id="cnpj">
          </div>

          <div>
            <label for="cidade">Cidade</label>
            <input required class="valid-input" v-model="cidade" type="text" id="cidade">
          </div>

          <div>
            <label for="responsavel">Responsavél</label>
            <input required class="valid-input" v-model="responsavel" type="text" id="responsavel">
          </div>

          <div>
            <label for="telefone">Telefone</label>
            <input required class="valid-input" v-model="telefone" type="text" id="telefone">
          </div>

          <div>
            <label for="email">Email</label>
            <input required class="valid-input" v-model="email" type="email" id="email">
          </div>

        </section>

        <div class="modal-btns">
          <button class="confirm" @click="salveProduct()">Editar</button>
          <button class="cancel" @click="close()">Voltar</button>
        </div>
    </sweet-modal>
  </div>
</template>

<script src="./scripts"></script>
