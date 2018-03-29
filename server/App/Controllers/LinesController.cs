using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL;
using DAL.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lines.App.Controllers
{
   
    [Route("api/Lines")]
    public class LinesController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] LineModelView lineModelView)
        {

            try
            {

                var lineBll = new LineBll();
                lineBll.Inserir(lineModelView);
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] LineModelView lineModelView)
        {

            try
            {

                var lineBll = new LineBll();
                lineBll.Atualizar(id, lineModelView);

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

                var lineBll = new LineBll();
                var line = lineBll.ObterPorId(id);

                return Json(line);

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
                var lineBll = new LineBll();
                lineBll.Delete(id);

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
                var lineBll = new LineBll();
                var listaDeLines= lineBll.ObterTodos();
                return Json(listaDeLines);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }

    }
}