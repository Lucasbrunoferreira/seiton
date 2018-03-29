using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;

namespace BancoDeDados.ObjetoDeAcesso
{
    public class LineDao
    {

        public void Inserir(Line line)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Line.Add(line);
                bancoDeDados.SaveChanges();

            }

        }

        public Line obeterPorId(int id)
        {
            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Line.Find(id);

            }

        }

        public void Deletar(int id)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                var line = obeterPorId(id);

                bancoDeDados.Line.Remove(line);
                bancoDeDados.SaveChanges();

            }

        }

        public void Atualizar(Line line)
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                bancoDeDados.Line.Update(line);
                bancoDeDados.SaveChanges();

            }

        }

        public List<Line> ObterTodos()
        {

            using (var bancoDeDados = new BancoDeDados())
            {

                return bancoDeDados.Line.ToList();

            }

        }

    }
}
