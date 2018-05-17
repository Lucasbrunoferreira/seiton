using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class ProductSaleDao
    {

        public void Inserir(ProductSale productSale)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                // bancoDeDados.ProductSale.Add(productSale);
                bancoDeDados.SaveChanges();

            }

        }


        public ProductSale obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return null;// bancoDeDados.ProductSale.Find(id);

            }

        }


        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var productSale = obeterPorId(id);

               // bancoDeDados.ProductSale.Remove(productSale);
                bancoDeDados.SaveChanges();

            }

        }

        public void Atualizar(ProductSale productSale)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                // bancoDeDados.ProductSale.Update(productSale);
                bancoDeDados.SaveChanges();

            }

        }


        public List<ProductSale> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return null; // eDados.ProductSale.ToList();

            }

        }



    }
}
