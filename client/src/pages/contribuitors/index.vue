<template>
  <div class="contribuitors-page">
    <headerBar></headerBar>

    <div class="wrapper">
      <section class="admin">
        <div class="title">

          <img src="/static/assets/icons/admin.svg">
          <h3>administradores</h3>
        </div>

        <ul class="admin-list">
         <li v-for="(admin, index) in getterAllUsers" :key="index" v-if="admin.idSector === 1">
            <div class="info" @click="showManager(admin)"  v-tooltip.bottom-start="'Clique para Gerenciar!'">
              <span><b>Nome:</b> {{ admin.nome }}</span>
              <span><b>CPF:</b> {{ admin.cpf }}</span>
              <span><b>Nasc:</b> {{ admin.dataNascimento }} </span>
            </div>

            <div class="btns-manager" v-if="isManager === admin.idContribuitor">
              <button @click="deleteContribuitor(admin)">
                <img src="/static/assets/icons/delete.svg">
              </button>

              <button @click="editContribuitor(admin)">
                <img src="/static/assets/icons/edit.svg">
              </button>
          </div>
          </li>
        </ul>

      </section>

      <section class="supervisor">
        <div class="title">
          <img src="/static/assets/icons/supervisor.svg">
          <h3>supervisores</h3>
        </div>

        <ul class="supervisor-list">
         <li v-for="(supervisor, index) in getterAllUsers" :key="index" v-if="supervisor.idSector === 3">
            <div class="info" @click="showManager(supervisor)"  v-tooltip.bottom-start="'Clique para Gerenciar!'">
              <span><b>Nome:</b> {{ supervisor.nome }}</span>
              <span><b>CPF:</b> {{ supervisor.cpf }}</span>
              <span><b>Nasc:</b> {{ supervisor.dataNascimento }} </span>
            </div>

            <div class="btns-manager" v-if="isManager === supervisor.idContribuitor">
              <button @click="deleteContribuitor(supervisor)">
                <img src="/static/assets/icons/delete.svg">
              </button>

              <button @click="editContribuitor(supervisor)">
                <img src="/static/assets/icons/edit.svg">
              </button>
          </div>
          </li>
        </ul>
      </section>

      <section class="atendance">
        <div class="title">
          <img src="/static/assets/icons/atendente.svg">
          <h3>atendentes</h3>
        </div>

        <ul class="atendance-list">
          <li v-for="(atendance, index) in getterAllUsers" :key="index" v-if="atendance.idSector === 2">
            <div class="info" @click="showManager(atendance)"  v-tooltip.bottom-start="'Clique para Gerenciar!'">
              <span><b>Nome:</b> {{ atendance.nome }}</span>
              <span><b>CPF:</b> {{ atendance.cpf }}</span>
              <span><b>Nasc:</b> {{ atendance.dataNascimento }} </span>
            </div>

            <div class="btns-manager" v-if="isManager === atendance.idContribuitor">
              <button @click="deleteContribuitor(atendance)">
                <img src="/static/assets/icons/delete.svg">
              </button>

              <button @click="editContribuitor(atendance)">
                <img src="/static/assets/icons/edit.svg">
              </button>
          </div>
          </li>
        </ul>

      </section>
    </div>

    <button class="new-contribuitor" @click="openCreate()">
      <img src="/static/assets/icons/add.svg">
    </button>

      <sweet-modal overlay-theme="dark" blocking modal-theme="dark" ref="newUser" class="newProduct-modal">
        <h3>Novo Colaborador</h3>
        <section class="wrapper">
          <div>
            <label for="nome">Nome</label>
            <input required class="valid-input" v-model="nome" type="text" id="nome">
          </div>

          <div>
            <label for="usuario">Usuario</label>
            <input required class="valid-input" v-model="usuario" type="text" id="usuario">
          </div>

          <div>
            <label for="password">Senha</label>
            <input required class="valid-input" v-model="senha" type="password" id="password">
          </div>

          <div>
            <label for="confirmSenha">Confirmar Senha</label>
            <input required class="valid-input" v-model="confirmSenha" type="password" id="confirmSenha">
          </div>

          <div>
            <label for="cpf">CPF</label>
            <input required class="valid-input" v-model="cpf" type="text" id="cpf">
          </div>

          <div>
            <label for="dtVal">Data Nascimento</label>
            <input required class="valid-input" v-model="dataNascimento" type="date" id="dtVal">
          </div>

          <div>
            <label>Setor</label>
            <select required class="valid-select" v-model="idSector">
              <option v-for="(sector, index) in getterAllSectors" :key="index" :value="`${sector.idSector}`">{{ sector.nome }}</option>
            </select>
          </div>
        </section>

        <div class="modal-btns">
          <button class="confirm" @click="createUser()">Criar</button>
          <button class="cancel" @click="close()">Voltar</button>
        </div>
      </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="createdSuccess">
      <span>O Colaborador foi cadastrado com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="editeSuccess">
      <span>Dados atualizados com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="warning" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="error">
      <span>Houve algum erro durante o processo!</span>
    </sweet-modal>

    <sweet-modal icon="success" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="deletedSuccess">
      <span>O Colaborador foi removido com Sucesso!</span>
    </sweet-modal>

    <sweet-modal icon="error" hide-close-button blocking overlay-theme="dark" modal-theme="dark" ref="delete">
      <span>Deseja realmente remover este Colaborador?</span>
      <div class="modal-btns">
        <button class="confirm" @click="confirmDelete()">Sim</button>
        <button class="cancel" @click="close()">Não</button>
      </div>
    </sweet-modal>

      <sweet-modal overlay-theme="dark" blocking modal-theme="dark" ref="editUser" class="newProduct-modal">
        <h3>Editar dados do Colaborador</h3>
        <section class="wrapper">
          <div>
            <label for="nome">Nome</label>
            <input required class="valid-input" v-model="nome" type="text" id="nome">
          </div>

          <div>
            <label for="usuario">Usuario</label>
            <input required class="valid-input" v-model="usuario" type="text" id="usuario">
          </div>

          <div>
            <label for="password">Senha</label>
            <input required class="valid-input" v-model="senha" type="password" id="password">
          </div>

          <div>
            <label for="confirmSenha">Confirmar Senha</label>
            <input required class="valid-input" v-model="confirmSenha" type="password" id="confirmSenha">
          </div>

          <div>
            <label for="cpf">CPF</label>
            <input required class="valid-input" v-model="cpf" type="text" id="cpf">
          </div>

          <div>
            <label for="dtVal">Data Nascimento</label>
            <input required class="valid-input" v-model="dataNascimento" type="date" id="dtVal">
          </div>

          <div>
            <label>Setor</label>
            <select required class="valid-select" v-model="idSector">
              <option v-for="(sector, index) in getterAllSectors" :key="index" :value="`${sector.idSector}`">{{ sector.nome }}</option>
            </select>
          </div>
      </section>
      <div class="modal-btns">
        <button class="confirm" @click="salveUser()">Salvar</button>
        <button class="cancel" @click="close()">Voltar</button>
      </div>
    </sweet-modal>
  </div>
</template>

<script src="./scripts"></script>
