# Inventory Control

> Controle de estoque em plataforma WEB com serviços REST

> Introdução

``` bash

  As constantes modificações que ocorreram nas últimas décadas, a instabilidade, os grandes avanços 
  tecnológicos, a crescente competitividade e a globalização são alguns dos fatores que vêm fazendo
  com que as empresas lutam por uma melhor posição e sobrevivência no mercado.
  Com o grande crescimento do setor mercantil, hoje em dia se faz cada vez mais necessário o uso de 
  sistemas inteligentes. 
  Com isso criamos um sistema de controle de estoque, com ações automáticas, o sistema reconhece a 
  demanda de estoque dos produtos, notificando ou até mesmo efetuando pedido dos mesmo em caso de 
  baixo estoque.
  

```
> Objetivos Específicos

```bash
   * Desenvolver um sistema efetivo e de fácil uso.
   * Facilitar a manutenção do estoque de produtos.
   * Criar um controle de estoque capaz de contatar fornecedores.
   * Gerar relatórios para um controle de lucros.
   * Gerenciar dados para apresentação de pontos fortes e fracos.
 
 ```  
  
> Metodologia - Ferramentas

``` bash
  * Visual Studio - IDE de desenvolvimento que dá suporte a linguagem C#.
  * Visual Paradigm for UML - Software utilizado para desenvolver os diagramas UML.
  * Adobe XD CC - Software para modelagem de protótipos do nosso sistema “Seiton Inventory Control”.
  * MySQL Workbench - Sistema gerenciador de banco de dados, utilizado para fazer o gerenciamento dos dados do
    sistema “Seiton Inventory Control”.
  * Vue.JS - Framework javascript progressivo para a construção de interfaces de usuário.
  * É uma iniciativa da empresa Microsoft, que visa uma plataforma única para desenvolvimento e execução de 
    sistemas e aplicações(.Net Framework).

  ```






### Rodando Front-end

``` bash
#Entre na pasta InventoryControl - front e execute os seguintes comando no terminal

# Instalar as dependencias
npm install

# Rodar o projeto no localhost:8080
npm run dev

CERTIFIQUE-SE QUE O BACK TAMBEM ESTEJA RODANDO

```

### Comando da Migrations

``` bash
# Acesse o menu EXIBIR > OUTRAS JANELAS > CONSOLE DO GERENCIDAOR DE PACOTES.

# Rode o comando - cd DAL

# Depois rode o comando - dotnet ef database update -s ../App/App.csproj

```
