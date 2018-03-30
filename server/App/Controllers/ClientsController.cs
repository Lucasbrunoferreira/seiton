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

    [Route("api/Clients")]
    public class ClientsController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] ClientModelView clientModelView)
        {

            try
            {

                var clientBll = new ClientBll();
                clientBll.Inserir(clientModelView);
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ClientModelView clientModelView)
        {

            try
            {

                var clientBll = new ClientBll();
                clientBll.Atualizar(id, clientModelView);

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

                var clientBll = new ClientBll();
                var client = clientBll.ObterPorId(id);

                return Json(client);

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
                var clientBll = new ClientBll();
                clientBll.Delete(id);

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
                var clientBll = new ClientBll();
                var listaDeClient = clientBll.ObterTodos();
                return Json(listaDeClient);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }


    }
}