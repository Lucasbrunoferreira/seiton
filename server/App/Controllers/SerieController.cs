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
                return NoContent();

            }catch(Exception ex){

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SerieModelView serieModelView)
        {

            try
            {

                var serieBll = new SerieBll();
                serieBll.Atualizar(id, serieModelView);

                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }

        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {

            try
            {

                var serieBll = new SerieBll();
                var serie = serieBll.ObterPorId(id);

                return Json(serie);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var serieBll = new SerieBll();
                serieBll.Delete(id);

                return NoContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var serieBll = new SerieBll();
                var listaDeSeries = serieBll.ObterTodos();
                return Json(listaDeSeries);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }

    }
}