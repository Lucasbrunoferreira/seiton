using System;
using System.Collections.Generic;
using System.Text;
using BancoDeDados.ObjetoDeAcesso;
using DAL;
using DAL.Models;
using DAL.ModelView;

namespace App.BLL
{
    public class ProviderBll
    {

        public void Inserir(ProviderModelView providerModelView)
        {

            var provider = new Provider();

            provider = PreparaProvider(providerModelView, provider);

            var providerDao = new ProviderDao();
            providerDao.Inserir(provider);

        }

        public Provider ObterPorId(int id)
        {

            var providerDao = new ProviderDao();
            return providerDao.ObeterPorId(id);

        }

        public void Delete(int id)
        {

            var providerDao = new ProviderDao();
            providerDao.Deletar(id);

        }

        public void Atualizar(int id, ProviderModelView providerModelView)
        {

            var providerDao = new ProviderDao();
            var provider = providerDao.ObeterPorId(id);

            var providerAt = PreparaProvider(providerModelView, provider);

            providerAt.IdProvider = id;
            providerDao.Atualizar(providerAt);
        }

        public List<Provider> ObterTodos()
        {

            var providerDao = new ProviderDao();
            return providerDao.ObterTodos();

        }

        public Provider PreparaProvider(ProviderModelView providerModelView, Provider provider)
        {

            var provider1 = new Provider();
            ProviderDao providerDao = new ProviderDao();

            var providerExistente = providerDao.ObterPorCnpj(providerModelView.Cnpj);

            if(providerExistente != null)
            {
                throw new Exception("FORNECEDOR já existe.");
            }

            var cnpj = new ValidarCNPJ();

            if (providerModelView.Cnpj.Trim().Length == 0)
            {
                throw new Exception("Informe o CNPJ.");
            }
            else if(providerModelView.Nome.Trim().Length == 0)
            {
                throw new Exception("Informe o NOME.");
            }
            else if(providerModelView.Cidade.Trim().Length == 0)
            {
                throw new Exception("Informe a CIDADE.");
            }
            else if(providerModelView.Responsavel.Trim().Length == 0)
            {
                throw new Exception("Informe o RESPONSAVEL.");
            }
            else if(providerModelView.Telefone.Trim().Length == 0)
            {
                throw new Exception("Informe o TELEFONE.");
            }
            else if(providerModelView.Email.Trim().Length == 0)
            {
                throw new Exception("Informe o EMAIL.");
            }
            else if(cnpj.IsCnpj(providerModelView.Cnpj) == false)
            {
                throw new Exception("CNPJ INVÁLIDO.");
            }
            else
            {
                provider1.Cnpj = providerModelView.Cnpj;
                provider1.Nome = providerModelView.Nome;
                provider1.Cidade = providerModelView.Cidade;
                provider1.Responsavel = providerModelView.Responsavel;
                provider1.Telefone = providerModelView.Telefone;
                provider1.Email = providerModelView.Email;
            }

            return provider1;

        }

    }
}
