<template>
  <div class="clients-page">
    <headerBar></headerBar>

    <div class="search">
      <img src="/static/assets/icons/search.svg">
      <input type="text" class="search" v-model="search"/>
    </div>

    <section class="clients-wrapper">
      <ul class="clients-list">
        <li>
          <div class="client-info">
            <strong class="initials">LU</strong>
            <span class="name">Lucas Bruno Ferreira</span>
          </div>

          <div class="client-content">
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

      <li>
          <div class="client-info">
            <strong class="initials">KE</strong>
            <span class="name">Kevem Pedro</span>
          </div>

          <div class="client-content">
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>Três Marias</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>3488475689</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>kevempedro@gmail.com</span>
            </div>
          </div>
        </li>

      <li>
          <div class="client-info">
            <strong class="initials">CE</strong>
            <span class="name">Cecilya Rodrigues Pires</span>
          </div>

          <div class="client-content">
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>Rio de Janeiro</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>3498754126</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>cecilyarodrigues@gmail.com</span>
            </div>
          </div>
        </li>

      <li>
          <div class="client-info">
            <strong class="initials">CA</strong>
            <span class="name">Caio Ribeiro Pinto</span>
          </div>

          <div class="client-content">
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>Ubêrlandia</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>3495741236</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>caioribeiro@gmail.com</span>
            </div>
          </div>
        </li>

      <li>
          <div class="client-info">
            <strong class="initials">PE</strong>
            <span class="name">Pedro Augusto Nunes</span>
          </div>

          <div class="client-content">
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>Patos de Minas</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>3499546321</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>pedro_augusto@gmail.com</span>
            </div>
          </div>
        </li>

      <li>
          <div class="client-info">
            <strong class="initials">AN</strong>
            <span class="name">Ana Garcia Oliveira</span>
          </div>

          <div class="client-content">
            <div>
              <img src="/static/assets/icons/place.svg">
              <span>Patos de Minas</span>
            </div>
            <div>
              <img src="/static/assets/icons/phone.svg">
              <span>3498741236</span>
            </div>
            <div>
              <img src="/static/assets/icons/email.svg">
              <span>ana.garcia@gmail.com</span>
            </div>
          </div>
        </li>
      </ul>

      <section class="informations">
        <div class="wrapper">
          <img src="/static/assets/icons/clientes.svg">
          <div class="total">
            <span>Total de Clientes</span>
            <strong>06</strong>
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

    <button class="new-product">
      <img src="/static/assets/icons/add.svg">
    </button>
  </div>
</template>

<script src="./scripts"></script>
