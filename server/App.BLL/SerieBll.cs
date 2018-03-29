using System;
using System.Collections.Generic;
using System.Text;
using BancoDeDados.ModelView;
using BancoDeDados.Models;
using BancoDeDados.ObjetoDeAcesso;


namespace App.BLL
{
    public class SerieBll
    {

        public void Inserir(SerieModelView serieModelView)
        {

            var serie = new Serie();

            serie = PreparaSerie(serieModelView, serie);

            var serieDao = new SerieDao();
            serieDao.Inserir(serie);

        }

        public Serie ObterPorId(int id)
        {

            var serieDao = new SerieDao();
            return serieDao.obeterPorId(id);

        }

        public void Delete(int id)
        {

            var serieDao = new SerieDao();
            serieDao.Deletar(id);

        }

        public void Atualizar(int id, SerieModelView serieModelView)
        {

            var serieDao = new SerieDao();
            var serie = serieDao.obeterPorId(id);

            var serieAt = PreparaSerie(serieModelView, serie);

            serieAt.IdSerie = id;
            serieDao.Atualizar(serieAt);
        }

        public List<Serie> ObterTodos()
        {

            var serieDao = new SerieDao();
            return serieDao.ObterTodos();

        }


        public Serie PreparaSerie(SerieModelView serieModelView, Serie seire)
        {

            var serie = new Serie();

            serie.Nome = serieModelView.Nome;

            return serie;

        }

    }
}
