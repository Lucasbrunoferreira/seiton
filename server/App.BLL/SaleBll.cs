using BancoDeDados.ObjetoDeAcesso;
using DAL.Models;
using DAL.ModelView;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL
{
    public class SaleBll
    {

        public void Inserir(SaleModelView saleModelView)
        {

            var sale = new Sale();

            sale = PreparaSale(saleModelView, sale);

            var saleDao = new SaleDao();
            saleDao.Inserir(sale);

        }


        public Sale ObterPorId(int id)
        {

            var saleDao = new SaleDao();
            return saleDao.obeterPorId(id);

        }


        public void Delete(int id)
        {

            var saleDao = new SaleDao();
            saleDao.Deletar(id);

        }


        public void Atualizar(int id, SaleModelView saleModelView)
        {

            var saleDao = new SaleDao();
            var sale = saleDao.obeterPorId(id);

            var saleAt = PreparaSale(saleModelView, sale);

            saleAt.IdContribuitor = id;
            saleDao.Atualizar(saleAt);
        }

        public List<Sale> ObterTodos()
        {

            var saleDao = new SaleDao();
            return saleDao.ObterTodos();

        }



        public Sale PreparaSale(SaleModelView saleModelView, Sale sale)
        {

            var sale1 = new Sale();

            if (saleModelView.TipoVenda.Trim().Length == 0)
            {
                throw new Exception("Informe o TIPO DE VENDA.");
            }
            else if(saleModelView.DataVenda == null)
            {
                throw new Exception("Informe a DATA DE VENDA.");
            }
            else if (saleModelView.IdClient < 0)
            {
                throw new Exception("Informe o ID DO CLIENTE.");
            }
            else if (saleModelView.IdContribuitor < 0)
            {
                throw new Exception("Informe o ID DO CONTRIBUIDOR.");
            }
            else if(saleModelView.IdProduct < 0)
            {
                throw new Exception("Informe o ID DO PRODUTO.");
            }
            else if (saleModelView.Quantidade < 0)
            {
                throw new Exception("Informe a QUANTIDADE do PRODUTO");
            }
            else
            {
                sale1.TipoVenda = saleModelView.TipoVenda;
                sale1.DataVenda = saleModelView.DataVenda;
                sale1.IdClient = saleModelView.IdClient;
                sale1.IdContribuitor = saleModelView.IdContribuitor;
                sale1.IdProduct = saleModelView.IdProduct;
                sale1.Quantidade = saleModelView.Quantidade;
            }

            return sale1;

        }














    }
}
