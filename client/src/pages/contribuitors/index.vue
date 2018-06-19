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
          <li>
            <div class="info" @click="showManager()"  v-tooltip.bottom-start="'Clique para Gerenciar!'">
              <span><b>Nome:</b> Lucas Bruno Ferreira</span>
              <span><b>CPF:</b> 12835138625</span>
              <span><b>Nasc:</b>  20/11/1997</span>
            </div>

            <div class="btns-manager" v-if="isManager">
              <button>
                <img src="/static/assets/icons/delete.svg">
              </button>

              <button>
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
          <li>
            <div class="info" @click="showManager()"  v-tooltip.bottom-start="'Clique para Gerenciar!'">
              <span><b>Nome:</b> Lucas Bruno Ferreira</span>
              <span><b>CPF:</b> 12835138625</span>
              <span><b>Nasc:</b>  20/11/1997</span>
            </div>

            <div class="btns-manager" v-if="isManager">
              <button>
                <img src="/static/assets/icons/delete.svg">
              </button>

              <button>
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
          <li>
            <div class="info" @click="showManager()"  v-tooltip.bottom-start="'Clique para Gerenciar!'">
              <span><b>Nome:</b> Lucas Bruno Ferreira</span>
              <span><b>CPF:</b> 12835138625</span>
              <span><b>Nasc:</b>  20/11/1997</span>
            </div>

            <div class="btns-manager" v-if="isManager">
              <button>
                <img src="/static/assets/icons/delete.svg">
              </button>

              <button>
                <img src="/static/assets/icons/edit.svg">
              </button>
          </div>
          </li>
        </ul>

      </section>
    </div>

    <button class="new-contribuitor">
      <img src="/static/assets/icons/add.svg">
    </button>

  </div>
</template>

<script src="./scripts"></script>
