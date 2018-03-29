using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class SectorDao
    {

        public void Inserir(Sector sector)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Sector.Add(sector);
                bancoDeDados.SaveChanges();

            }

        }

        public Sector obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Sector.Find(id);

            }

        }

        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var sector = obeterPorId(id);

                bancoDeDados.Sector.Remove(sector);
                bancoDeDados.SaveChanges();

            }

        }

        public void Atualizar(Sector sector)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Sector.Update(sector);
                bancoDeDados.SaveChanges();

            }

        }

        public List<Sector> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Sector.ToList();

            }

        }

    }
}
