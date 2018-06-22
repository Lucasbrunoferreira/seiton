<template>
  <div class="clients-page">
    <headerBar></headerBar>

    <div class="search">
      <img src="/static/assets/icons/search.svg">
      <input type="text" class="search" v-model="search"/>
    </div>

    <section class="clients-wrapper">
      <ul class="clients-list">
        <li v-for="(client, index) in getterAllClients" :key="index" @click="manager(client)">
          <div class="client-info">
            <strong class="initials">{{ client.nomeRazaoSocial.substring(0, 2) }}</strong>
            <span class="name">{{ client.nomeRazaoSocial }}</span>
          </div>

          <div class="client-content">
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>{{ client.cidade }}</span>
            </div>
            <div>
              <img src="/static/assets/icons/street.svg">
              <span>{{ client.rua }}, {{ client.numeroDaCasa }}</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>{{ client.telefone }}</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>{{ client.email }}</span>
            </div>
          </div>

          <div class="btns-manager" v-if="isManager === client.idClient">
            <button @click="openDelete(client)">
              <img src="/static/assets/icons/delete.svg">
            </button>

            <button @click="openEdit(client)">
              <img src="/static/assets/icons/edit.svg">
            </button>
          </div>

        </li>
      </ul>

      <section class="informations">
        <div class="wrapper">
          <img src="/static/assets/icons/clientes.svg">
          <div class="total">
            <span>Total de Clientes</span>
            <strong>{{ this.getterAllClients.length }}</strong>
          </div>
        </div>

        <div class="birthdays">
          <div class="btd-header">
            <span class="icon">
              <img src="/static/assets/icons/cake.svg">
            </span>
            <span class="title">Próximos Aniversariantes</span>
          </div>
          <div class="btd-content">
            <span>Lucas Bruno Ferreira - 19/06 </span>
            <span>Ana Garcia Oliveira - 26/06 </span>
          </div>
        </div>

      </section>
    </section>

    <button class="new-product" @click="openCreate">
      <img src="/static/assets/icons/add.svg">
    </button>

      <sweet-modal overlay-theme="dark" blocking modal-theme="dark" ref="newClient" class="newProduct-modal">
        <h3>Cadastrar novo Cliente</h3>
        <section class="wrapper">
          <div>
            <label for="nomeRazaoSocial">Razão Social</label>
            <input required class="valid-input" v-model="nomeRazaoSocial" type="text" id="nomeRazaoSocial">
          </div>

          <div>
            <label for="cpf">CPF/CNPJ</label>
            <input required class="valid-input" v-model="cpf" type="cpf" id="cod">
          </div>

          <div>
            <label for="dataNascimento">Fundação</label>
            <input required class="valid-input" v-model="dataNascimento" type="date" id="dataNascimento">
          </div>

          <div>
            <label for="cep">CEP</label>
            <input required class="valid-input" v-model="cep" type="text" id="cep">
          </div>

          <div>
            <label for="cidade">Cidade</label>
            <input required class="valid-input" v-model="cidade" type="text" id="cidade">
          </div>

          <div>
            <label for="bairro">Bairro</label>
            <input required class="valid-input" v-model="bairro" type="text" id="bairro">
          </div>

          <div>
            <label for="rua">Rua</label>
            <input required class="valid-input" v-model="rua" type="text" id="rua">
          </div>

          <div>
            <label for="numeroDaCasa">Numero</label>
            <input required class="valid-input" v-model="numeroDaCasa" min="0" type="number" id="numeroDaCasa">
          </div>

          <div>
            <label for="pontoReferencia">Ponto Referencia</label>
            <input required class="valid-input" v-model="pontoReferencia" type="text" id="pontoReferencia">
          </div>

          <div>
            <label for="estado">Estado</label>
            <input required class="valid-input" v-model="estado" type="text" id="estado">
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
          <button class="confirm" @click="createClient()">Criar</button>
          <button class="cancel" @click="close()">Voltar</button>
        </div>
    </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="createdSuccess">
      <span>O Cliente foi cadastrado com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="deletedSuccess">
      <span>O Cliente foi removido com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="editedSuccess">
      <span>Dados alterados com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="warning" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="error">
      <span>Houve algum erro durante o processo!</span>
    </sweet-modal>

    <sweet-modal icon="error" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="delete">
      <span>Deseja realmente remover este cliente?</span>
      <div class="modal-btns">
        <button class="confirm" @click="confirmDelete()">Sim</button>
        <button class="cancel" @click="close()">Não</button>
      </div>
    </sweet-modal>

      <sweet-modal overlay-theme="dark" blocking modal-theme="dark" ref="editClient" class="newProduct-modal">
        <h3>Editar dados do Cliente</h3>
        <section class="wrapper">
          <div>
            <label for="nomeRazaoSocial">Razão Social</label>
            <input required class="valid-input" v-model="nomeRazaoSocial" type="text" id="nomeRazaoSocial">
          </div>

          <div>
            <label for="cpf">CPF/CNPJ</label>
            <input required class="valid-input" v-model="cpf" type="cpf" id="cod">
          </div>

          <div>
            <label for="dataNascimento">Fundação</label>
            <input required class="valid-input" v-model="dataNascimento" type="date" id="dataNascimento">
          </div>

          <div>
            <label for="cep">CEP</label>
            <input required class="valid-input" v-model="cep" type="text" id="cep">
          </div>

          <div>
            <label for="cidade">Cidade</label>
            <input required class="valid-input" v-model="cidade" type="text" id="cidade">
          </div>

          <div>
            <label for="bairro">Bairro</label>
            <input required class="valid-input" v-model="bairro" type="text" id="bairro">
          </div>

          <div>
            <label for="rua">Rua</label>
            <input required class="valid-input" v-model="rua" type="text" id="rua">
          </div>

          <div>
            <label for="numeroDaCasa">Numero</label>
            <input required class="valid-input" v-model="numeroDaCasa" min="0" type="number" id="numeroDaCasa">
          </div>

          <div>
            <label for="pontoReferencia">Ponto Referencia</label>
            <input required class="valid-input" v-model="pontoReferencia" type="text" id="pontoReferencia">
          </div>

          <div>
            <label for="estado">Estado</label>
            <input required class="valid-input" v-model="estado" type="text" id="estado">
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
          <button class="confirm" @click="salveClient()">Salvar</button>
          <button class="cancel" @click="close()">Voltar</button>
        </div>
    </sweet-modal>
  </div>
</template>

<script src="./scripts"></script>
