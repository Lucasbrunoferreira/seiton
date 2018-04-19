using BancoDeDados.ObjetoDeAcesso;
using DAL.Models;
using DAL.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL
{
    public class ProductBll
    {

        public void Inserir(ProductModelView productModelView)
        {

            var product = new Product();

            product = PreparaProduct(productModelView, product);

            var productDao = new ProductDao();
            productDao.Inserir(product);

        }

        public Product ObterPorId(int id)
        {

            var productDao = new ProductDao();
            return productDao.obeterPorId(id);

        }



        public void Delete(int id)
        {

            var productDao = new ProductDao();
            productDao.Deletar(id);

        }


        public void Atualizar(int id, ProductModelView productModelView)
        {

            var productDao = new ProductDao();
            var product = productDao.obeterPorId(id);

            var productAt = PreparaProduct(productModelView, product);

            productAt.IdProduct = id;
            productDao.Atualizar(productAt);
        }

        public List<Product> ObterTodos()
        {

            var productDao = new ProductDao();
            return productDao.ObterTodos();

        }


        public Product PreparaProduct(ProductModelView productModelView, Product product)
        {

            var product1 = new Product();


            if(productModelView.CodigoBarra <= 0)
            {
                throw new Exception("Informe um CÓDIGO de barra do produto.");
            }
            else if (productModelView.Nome.Trim().Length == 0)
            {
                throw new Exception("Informe o NOME do produto.");
            }
            else if (productModelView.Estoque <= 0)
            {
                throw new Exception("Informe a QUANTIDADE do produto.");
            }
            else if (productModelView.Lote.Trim().Length == 0)
            {
                throw new Exception("Informe o LOTE do produto.");
            }
            else if (productModelView.DataValidade.Trim().Length == 0)
            {
                throw new Exception("Informe a DATA DE VALIDADE do produto."); 
            }
            else if (productModelView.DataCadastro.Trim().Length == 0)
            {
                throw new Exception("Informe a DATA DE CADASTRO do produto.");
            }
            else if (productModelView.DataEntrada.Trim().Length == 0)
            {
                throw new Exception("Informe a DATA DE ENTRADA do produto.");
            }
            else if (productModelView.PrecoCompra <= 0)
            {
                throw new Exception("Informe o PREÇO DE COMPRA do produto.");
            }
            else if (productModelView.PrecoVenda <= 0)
            {
                throw new Exception("Informe o PREÇO DE VENDA do produto.");
            }
            else if (productModelView.Icms <= 0)
            {
                throw new Exception("Informeo o ICMS do produto."); 
            }
            else if (productModelView.IdLine <= 0)
            {
                throw new Exception("Informe a LINHA do produto.");
            }
            else if (productModelView.IdProvider <= 0)
            {
                throw new Exception("Informe o FORNECEDOR do produto.");
            }
            else
            {
                product1.StatusProduct = productModelView.StatusProduct;
                product1.CodigoBarra = productModelView.CodigoBarra;
                product1.Nome = productModelView.Nome;
                product1.Estoque = productModelView.Estoque;
                product1.Lote = productModelView.Lote;
                product1.DataValidade = productModelView.DataValidade;
                product1.DataCadastro = productModelView.DataCadastro;
                product1.DataEntrada = productModelView.DataEntrada;
                product1.PrecoCompra = productModelView.PrecoCompra;
                product1.PrecoVenda = productModelView.PrecoVenda;
                product1.Desconto = productModelView.Desconto;
                product1.Icms = productModelView.Icms;
                product1.IdLine = productModelView.IdLine;
                product1.IdProvider = productModelView.IdProvider;
            }

            return product1;

        }




    }
}
