using System;
using System.Collections.Generic;
using System.Text;
using BancoDeDados.ObjetoDeAcesso;
using DAL.Models;
using DAL.ModelView;

namespace App.BLL
{
    public class LineBll
    {

        public void Inserir(LineModelView lineModelView)
        {

            var line = new Line();

            line = PreparaLine(lineModelView, line);

            var lineDao = new LineDao();
            lineDao.Inserir(line);

        }

        public Line ObterPorId(int id)
        {

            var lineDao = new LineDao();
            return lineDao.obeterPorId(id);

        }

        public void Delete(int id)
        {

            var lineDao = new LineDao();
            lineDao.Deletar(id);

        }

        public void Atualizar(int id, LineModelView lineModelView)
        {

            var lineDao = new LineDao();
            var line = lineDao.obeterPorId(id);

            var lineAt = PreparaLine(lineModelView, line);

            lineAt.IdLine = id;
            lineDao.Atualizar(lineAt);
        }

        public List<Line> ObterTodos()
        {

            var lineDao = new LineDao();
            return lineDao.ObterTodos();

        }

        public Line PreparaLine(LineModelView lineModelView, Line line)
        {

            var line1 = new Line();

            if(lineModelView.Nome.Trim().Length != 0)
            {

                line1.Nome = lineModelView.Nome;

            }

            return line1;

        }

    }
}
