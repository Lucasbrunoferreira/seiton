using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class ProductDao
    {
        public void Inserir(Product product)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Product.Add(product);
                bancoDeDados.SaveChanges();

            }

        }


        public Product obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Product.Find(id);

            }

        }


        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var product = obeterPorId(id);

                bancoDeDados.Product.Remove(product);
                bancoDeDados.SaveChanges();

            }

        }



        public void Atualizar(Product product)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Product.Update(product);
                bancoDeDados.SaveChanges();

            }

        }

        public List<Product> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Product.ToList();

            }

        }




    }
}
