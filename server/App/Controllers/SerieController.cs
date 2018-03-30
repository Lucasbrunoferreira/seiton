using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BancoDeDados.ModelView;
using App.BLL;

namespace Series.App.Controllers
{
    [Route("api/Serie")]
    public class SerieController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] SerieModelView serieModelView)
        {

            try{

                var serieBll = new SerieBll();
                serieBll.Inserir(serieModelView);
                return StatusCode(201); //Postado com sucesso

            }
            catch(Exception ex){

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SerieModelView serieModelView)
        {

            try
            {

                var serieBll = new SerieBll();
                serieBll.Atualizar(id, serieModelView);
                return StatusCode(204); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }

        }

        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {

            try
            {

                var serieBll = new SerieBll();
                var serie = serieBll.ObterPorId(id);
                return Json(serie); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var serieBll = new SerieBll();
                serieBll.Delete(id);
                return StatusCode(204); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var serieBll = new SerieBll();
                var listaDeSeries = serieBll.ObterTodos();
                return Json(listaDeSeries); //Recurso Encontrado mesmo que estege nulo


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

    }
}