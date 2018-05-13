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

        public Provider ObeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Provider.Find(id);

            }

        }

        public Provider ObterPorCnpj(string cnpj)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Provider.Where(x => x.Cnpj == cnpj).FirstOrDefault();
            }

        }

        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var provider = ObeterPorId(id);

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
