using System;
using System.Collections.Generic;
using System.Text;
using App.BLL.HashUtil;
using BancoDeDados.ObjetoDeAcesso;
using DAL;
using DAL.Models;
using DAL.ModelView;

namespace BLL
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

        public Contribuitor Login(string usuario, string senha)
        {
            var contribuitorDao = new ContribuitorDao();

            Contribuitor contribuitor = contribuitorDao.ObeterPorUsuario(usuario);

            if(contribuitor == null)
            {
                throw new Exception("USUÁRIO inexistente.");
            }
               
            else if(HashService.CheckPassword(senha, contribuitor.Senha))
            {
                return contribuitor;
            }
            else
            {
                throw new Exception("SENHA inválida.");
            }

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

            var contribuitorAt = AtualizarContribuitor(contribuitorModelView, contribuitor);

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
            ContribuitorDao contribuitorDao = new ContribuitorDao();
            var contribuitorExistente = contribuitorDao.ObterPorCpf(contribuitorModelView.Cpf);

            if (contribuitorExistente != null)
            {
                throw new Exception("Contribuidor já cadastrado");
            }

            var cpf = new ValidarCPF();


            if (contribuitorModelView.Nome.Trim().Length == 0)
            {
                throw new Exception("Informe o NOME.");
            }
            else if (contribuitorModelView.Usuario.Trim().Length == 0)
            {
                throw new Exception("Informe o USUÁRIO.");
            }
            else if (contribuitorModelView.Senha.Trim().Length == 0)
            {
                throw new Exception("Informe a SENHA.");
            }
            else if (contribuitorModelView.DataNascimento == null)
            {
                throw new Exception("Informe a DATA DE NASCIMENTO.");
            }
            else if (contribuitorModelView.Cpf.Trim().Length == 0)
            {
                throw new Exception("Informe o CPF.");
            }
            else if (contribuitorModelView.IdSector == 0)
            {
                throw new Exception("Iforme o SETOR.");
            }
            else if (contribuitorModelView.DataCadastro == null)
            {
                throw new Exception("Iforme a DATA DE CADASTRO.");
            }
            else if (cpf.IsCpf(contribuitorModelView.Cpf) == false)
            {
                throw new Exception("CPF INVÁLIDO.");
            }
            else
            {
                contribuitor1.Nome = contribuitorModelView.Nome;
                contribuitor1.Usuario = contribuitorModelView.Usuario;
                contribuitor1.Senha = HashService.HashPassword(contribuitorModelView.Senha);
                contribuitor1.Cpf = contribuitorModelView.Cpf;
                contribuitor1.DataNascimento = contribuitorModelView.DataNascimento;
                contribuitor1.DataCadastro = contribuitorModelView.DataCadastro;
                contribuitor1.IdSector = contribuitorModelView.IdSector;
            }

            return contribuitor1;

        }

        public Contribuitor AtualizarContribuitor(ContribuitorModelView contribuitorModelView, Contribuitor contribuitor)
        {

            var contribuitor1 = new Contribuitor();
            ContribuitorDao contribuitorDao = new ContribuitorDao();

            var cpf = new ValidarCPF();


            if (contribuitorModelView.Nome.Trim().Length == 0)
            {
                throw new Exception("Informe o NOME.");
            }
            else if (contribuitorModelView.Usuario.Trim().Length == 0)
            {
                throw new Exception("Informe o USUÁRIO.");
            }
            else if (contribuitorModelView.Senha.Trim().Length == 0)
            {
                throw new Exception("Informe a SENHA.");
            }
            else if (contribuitorModelView.DataNascimento == null)
            {
                throw new Exception("Informe a DATA DE NASCIMENTO.");
            }
            else if (contribuitorModelView.Cpf.Trim().Length == 0)
            {
                throw new Exception("Informe o CPF.");
            }
            else if (contribuitorModelView.IdSector == 0)
            {
                throw new Exception("Iforme o SETOR.");
            }
            else if (contribuitorModelView.DataCadastro == null)
            {
                throw new Exception("Iforme a DATA DE CADASTRO.");
            }
            else if (cpf.IsCpf(contribuitorModelView.Cpf) == false)
            {
                throw new Exception("CPF INVÁLIDO.");
            }
            else
            {
                contribuitor1.Nome = contribuitorModelView.Nome;
                contribuitor1.Usuario = contribuitorModelView.Usuario;
                contribuitor1.Senha = HashService.HashPassword(contribuitorModelView.Senha);
                contribuitor1.Cpf = contribuitorModelView.Cpf;
                contribuitor1.DataNascimento = contribuitorModelView.DataNascimento;
                contribuitor1.DataCadastro = contribuitorModelView.DataCadastro;
                contribuitor1.IdSector = contribuitorModelView.IdSector;
            }

            return contribuitor1;

        }

    }
}
