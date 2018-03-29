using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class ContribuitorDao
    {

        public void Inserir(Contribuitor contribuitor)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Contribuitor.Add(contribuitor);
                bancoDeDados.SaveChanges();

            }

        }

        public Contribuitor obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Contribuitor.Find(id);

            }

        }

        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var contribuitor = obeterPorId(id);

                bancoDeDados.Contribuitor.Remove(contribuitor);
                bancoDeDados.SaveChanges();

            }

        }

        public void Atualizar(Contribuitor contribuitor)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Contribuitor.Update(contribuitor);
                bancoDeDados.SaveChanges();

            }

        }

        public List<Contribuitor> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Contribuitor.ToList();

            }

        }

    }
}
