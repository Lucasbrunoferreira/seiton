using System;
using System.Collections.Generic;
using System.Text;
using BancoDeDados.ObjetoDeAcesso;
using DAL.Models;
using DAL.ModelView;

namespace App.BLL
{
    public class ContribuitorBll
    {

        public void Inserir(ContribuitorModelView contribuitorModelView)
        {

            var contribuitor  = new Contribuitor();

            contribuitor = PreparaContribuitor(contribuitorModelView, contribuitor);

            var contribuitorDao = new ContribuitorDao();
            contribuitorDao.Inserir(contribuitor);

        }

        public Contribuitor ObterPorId(int id)
        {

            var contribuitorDao = new ContribuitorDao();
            return contribuitorDao.obeterPorId(id);

        }

        public void Delete(int id)
        {

            var contribuitorDao = new ContribuitorDao();
            contribuitorDao.Deletar(id);

        }

        public void Atualizar(int id, ContribuitorModelView contribuitorModelView)
        {

            var contribuitorDao = new ContribuitorDao();
            var contribuitor = contribuitorDao.obeterPorId(id);

            var contribuitorAt = PreparaContribuitor(contribuitorModelView, contribuitor);

            contribuitorAt.IdContribuitor = id;
            contribuitorDao.Atualizar(contribuitorAt);
        }

        public List<Contribuitor> ObterTodos()
        {

            var contribuitorDao = new ContribuitorDao();
            return contribuitorDao.ObterTodos();

        }

        public Contribuitor PreparaContribuitor(ContribuitorModelView contribuitorModelView, Contribuitor contribuitor)
        {

            var contribuitor1 = new Contribuitor();

            if (contribuitorModelView.Nome.Trim().Length != 0 && contribuitorModelView.Usuario.Trim().Length != 0 &&
                contribuitorModelView.Senha.Trim().Length != 0 && contribuitorModelView.DataNascimento.Trim().Length != 0 
                && contribuitorModelView.Cpf.Trim().Length != 0 && contribuitorModelView.IdSector > 0  && 
                contribuitorModelView.DataCadastro.Trim().Length != 0)
            {

                contribuitor1.Nome = contribuitorModelView.Nome;
                contribuitor1.Usuario = contribuitorModelView.Usuario;
                contribuitor1.Senha = contribuitorModelView.Senha;
                contribuitor1.Cpf = contribuitorModelView.Cpf;
                contribuitor1.DataNascimento = contribuitorModelView.DataNascimento;
                contribuitor1.DataCadastro = contribuitorModelView.DataCadastro;
                contribuitor1.IdSector = contribuitorModelView.IdSector;

            }

            return contribuitor1;

        }

    }
}
