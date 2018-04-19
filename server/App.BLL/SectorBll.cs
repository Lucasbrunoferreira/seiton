using System;
using System.Collections.Generic;
using System.Text;
using BancoDeDados.ObjetoDeAcesso;
using DAL.Models;
using DAL.ModelView;

namespace App.BLL
{
    public class SectorBll
    {

        public void Inserir(SectorModelView sectorModelView)
        {

            var sector = new Sector();

            sector = PreparaSector(sectorModelView, sector);

            var sectorDao = new SectorDao();
            sectorDao.Inserir(sector);

        }

        public Sector ObterPorId(int id)
        {

            var sectorDao = new SectorDao();
            return sectorDao.obeterPorId(id);

        }

        public void Delete(int id)
        {

            var sectorDao = new SectorDao();
            sectorDao.Deletar(id);

        }

        public void Atualizar(int id, SectorModelView sectorModelView)
        {

            var sectorDao = new SectorDao();
            var line = sectorDao.obeterPorId(id);

            var sectorAt = PreparaSector(sectorModelView, line);

            sectorAt.IdSector = id;
            sectorDao.Atualizar(sectorAt);
        }

        public List<Sector> ObterTodos()
        {

            var sectorDao = new SectorDao();
            return sectorDao.ObterTodos();

        }

        public Sector PreparaSector(SectorModelView sectorModelView, Sector sector)
        {

            var sector1 = new Sector();


            if (sectorModelView.Nome.Trim().Length == 0)
            {
                throw new Exception("Informe o NOME do setor.");
            }
            else if (sectorModelView.NivelAcesso <= 0)
            {
                throw new Exception("Informe o NIVEL DE ACESSO do setor.");
            }

            else
            {
                sector1.Nome = sectorModelView.Nome;
                sector1.NivelAcesso = sectorModelView.NivelAcesso;
            }

            return sector1;

        }

    }
}
