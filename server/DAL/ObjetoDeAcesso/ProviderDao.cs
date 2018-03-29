using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class ProviderDao
    {

        public void Inserir(Provider provider)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Provider.Add(provider);
                bancoDeDados.SaveChanges();

            }

        }

        public Provider obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Provider.Find(id);

            }

        }

        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var provider = obeterPorId(id);

                bancoDeDados.Provider.Remove(provider);
                bancoDeDados.SaveChanges();

            }

        }

        public void Atualizar(Provider provider)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Provider.Update(provider);
                bancoDeDados.SaveChanges();

            }

        }

        public List<Provider> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Provider.ToList();

            }

        }

    }
}
