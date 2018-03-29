using BancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class SerieDao
    {

        public void Inserir(Serie serie)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Series.Add(serie);
                bancoDeDados.SaveChanges();

            }

        }

        public Serie obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Series.Find(id);

            }

        }

        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var serie = obeterPorId(id);

                bancoDeDados.Series.Remove(serie);
                bancoDeDados.SaveChanges();

            }

        }

        public void Atualizar(Serie serie)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Series.Update(serie);
                bancoDeDados.SaveChanges();

            }

        }

        public List<Serie> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Series.ToList();

            }

        }

    }
}
