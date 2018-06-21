using BancoDeDados.ObjetoDeAcesso;
using DAL.Models;
using DAL.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL
{
    public class ProductSaleBll
    {


        public void Inserir(ProductSaleModelView productSaleModelView)
        {

            var productSale = new ProductSale();

            productSale = PreparaProductSale(productSaleModelView, productSale);

            var productSaleDao = new ProductSaleDao();
            productSaleDao.Inserir(productSale);

        }

        public List<ProductSale> RetornarPorData(DateTime data)
        {

            var productSaleDao = new ProductSaleDao();

            return productSaleDao.RetornarPorData(data);

        }

        public List<ProductSale> RetornarPorDataAtual(DateTime dataAtual)
        {

            var productSaleDao = new ProductSaleDao();

            return productSaleDao.RetornarPorDataAtual(dataAtual);

        }

        public ProductSale ObterPorId(int id)
        {

            var productSaleDao = new ProductSaleDao();
            return productSaleDao.ObeterPorId(id);

        }

        public void Delete(int id)
        {

            var productSaleDao = new ProductSaleDao();
            productSaleDao.Deletar(id);

        }

        public void Atualizar(int id, ProductSaleModelView productSaleModelView)
        {

            var productSaleDao = new ProductSaleDao();
            var productSale = productSaleDao.ObeterPorId(id);

            var productSaleAt = PreparaProductSale(productSaleModelView, productSale);

            // productSaleAt.IdProductSale = id;
            productSaleDao.Atualizar(productSaleAt);

        }


        public List<ProductSale> ObterTodos()
        {

            var productSaleDao = new ProductSaleDao();
            return productSaleDao.ObterTodos();

        }


        public ProductSale PreparaProductSale(ProductSaleModelView productSaleModelView, ProductSale productSale)
        {

            var productSale1 = new ProductSale();

            if (productSaleModelView.IdSale <= 0)
            {
                throw new Exception("Informe o uma VENDA(ID) de produto.");
            }
            else if (productSaleModelView.IdProduct <= 0)
            {
                throw new Exception("Informe o um PRODUTO(ID) de venda.");
            }
            else if (productSaleModelView.SaleDate == null)
            {
                throw new Exception("Informe a data de VENDA do produto.");
            }

            else
            {
                productSale1.IdSale = productSaleModelView.IdSale;
                productSale1.IdProduct = productSaleModelView.IdProduct;
                productSale1.SaleDate = productSaleModelView.SaleDate;
            }

            return productSale1;

        }


    }
}
