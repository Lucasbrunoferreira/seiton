using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class SaleDao
    {

        public void Inserir(Sale sale)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Sale.Add(sale);
                bancoDeDados.SaveChanges();

            }

        }


        public Sale obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Sale.Find(id);

            }

        }



        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var sale = obeterPorId(id);

                bancoDeDados.Sale.Remove(sale);
                bancoDeDados.SaveChanges();

            }

        }



        public void Atualizar(Sale sale)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Sale.Update(sale);
                bancoDeDados.SaveChanges();

            }

        }

        public List<Sale> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Sale.ToList();

            }

        }







    }
}
