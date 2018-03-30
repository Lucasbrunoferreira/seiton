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

            if (saleModelView.TipoVenda.Trim().Length != 0 && saleModelView.DataVenda.Trim().Length != 0 &&
                saleModelView.IdClient > 0 && saleModelView.IdContribuitor > 0)
            {

                sale1.TipoVenda = saleModelView.TipoVenda;
                sale1.DataVenda = saleModelView.DataVenda;
                sale1.IdClient = saleModelView.IdClient;
                sale1.IdContribuitor = saleModelView.IdContribuitor;
               

            }

            return sale1;

        }














    }
}
