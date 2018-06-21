using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class ClientDao
    {

        public void Inserir(Client client)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Client.Add(client);
                bancoDeDados.SaveChanges();

            }

        }

        public Client ObeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Client.Find(id);

            }

        }

        public Client ObeterPorCpf(string cpf)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Client.Where(x => x.Cpf == cpf).FirstOrDefault();

            }

        }

        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var client = ObeterPorId(id);

                bancoDeDados.Client.Remove(client);
                bancoDeDados.SaveChanges();

            }

        }


        public void Atualizar(Client client)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Client.Update(client);
                bancoDeDados.SaveChanges();

            }

        }


        public List<Client> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Client.ToList();

            }

        }


    }
}
