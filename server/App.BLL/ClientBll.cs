using BancoDeDados.ObjetoDeAcesso;
using DAL;
using DAL.Models;
using DAL.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL
{
    public class ClientBll
    {
       
        public void Inserir(ClientModelView clientModelView)
        {

            var client = new Client();

            client = PreparaClient(clientModelView, client);

            var clientDao = new ClientDao();
            clientDao.Inserir(client);

        }


        public Client ObterPorId(int id)
        {

            var clientDao = new ClientDao();
            return clientDao.obeterPorId(id);

        }



        public void Delete(int id)
        {

            var clientDao = new ClientDao();
            clientDao.Deletar(id);

        }

        public void Atualizar(int id, ClientModelView clientModelView)
        {

            var clientDao = new ClientDao();
            var client = clientDao.obeterPorId(id);

            var clientAt = PreparaClient(clientModelView, client);

            clientAt.IdClient = id;
            clientDao.Atualizar(clientAt);
        }



        public List<Client> ObterTodos()
        {

            var clientDao = new ClientDao();
            return clientDao.ObterTodos();

        }


        public Client PreparaClient(ClientModelView clientModelView, Client client)
        {

            var client1 = new Client();
            var cpf = new ValidarCPF();

            if(clientModelView.NomeRazaoSocial.Trim().Length == 0)
            {
                throw new Exception("Informe o NOME");
            }
            else if (clientModelView.Cpf.Trim().Length == 0)
            {
                throw new Exception("Informe o CPF");
            }
            else if(clientModelView.DataNascimento.Trim().Length == 0)
            {
                throw new Exception("Informe a DATA DE NASCIMENTO.");
            }
            else if (clientModelView.Cep.Trim().Length == 0)
            {
                throw new Exception("Informe o CEP.");
            }
            else if (clientModelView.Cidade.Trim().Length == 0)
            {
                throw new Exception("Informe a CIDADE.");
            }
            else if (clientModelView.Bairro.Trim().Length == 0)
            {
                throw new Exception("Informe o BAIRRO.");
            }
            else if (clientModelView.Rua.Trim().Length == 0)
            {
                throw new Exception("Informe a RUA.");
            }
            else if (clientModelView.NumeroDaCasa < 0)
            {
                throw new Exception("Informe o NUEMRO DE CASA.");
            }
            else if (clientModelView.Estado.Trim().Length == 0)
            {
                throw new Exception("Informe o ESTADO.");
            }
            else if(clientModelView.Telefone.Trim().Length == 0)
            {
                throw new Exception("Informeo o TELEFONE.");
            }
            else if (clientModelView.Email.Trim().Length == 0)
            {
                throw new Exception("Informe o EMAIL.");
            }
            else if(clientModelView.DataCadastro.Trim().Length == 0)
            {
                throw new Exception("Informe uma DATA DE CADASTRO.");
            }
            else if (cpf.IsCpf(clientModelView.Cpf) != false)
            {
                throw new Exception("CPF INVÁLIDO");
            }
            else
            {
                client1.NomeRazaoSocial = clientModelView.NomeRazaoSocial;
                client1.Cpf = clientModelView.Cpf;
                client1.DataNascimento = clientModelView.DataNascimento;
                client1.Cep = clientModelView.Cep;
                client1.Cidade = clientModelView.Cidade;
                client1.Bairro = clientModelView.Bairro;
                client1.Rua = clientModelView.Rua;
                client1.NumeroDaCasa = clientModelView.NumeroDaCasa;
                client1.PontoReferencia = clientModelView.PontoReferencia;
                client1.Estado = clientModelView.Estado;
                client1.Telefone = clientModelView.Telefone;
                client1.Email = clientModelView.Email;
                client1.DataCadastro = clientModelView.DataCadastro;
            }

            return client1;

        }

    }
}
