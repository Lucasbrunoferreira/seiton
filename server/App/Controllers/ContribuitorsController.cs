using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL;
using DAL.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
 
    [Route("api/Contribuitors")]
    public class ContribuitorsController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] ContribuitorModelView contribuitorModelView)
        {

            try
            {

                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Inserir(contribuitorModelView);
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ContribuitorModelView contribuitorModelView)
        {

            try
            {

                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Atualizar(id, contribuitorModelView);

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

                var contribuitorBll = new ContribuitorBll();
                var contribuitor = contribuitorBll.ObterPorId(id);

                return Json(contribuitor);

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
                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Delete(id);

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
                var contribuitorBll = new ContribuitorBll();
                var listaDeContribuitor = contribuitorBll.ObterTodos();
                return Json(listaDeContribuitor);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }

    }
}