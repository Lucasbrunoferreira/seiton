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
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }

        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ClientModelView clientModelView)
        {

            try
            {

                var clientBll = new ClientBll();
                clientBll.Atualizar(id, clientModelView);
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

                var clientBll = new ClientBll();
                var client = clientBll.ObterPorId(id); //Recurso Encontrado mesmo que estege nulo;
                return Json(client);

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
                var clientBll = new ClientBll();
                clientBll.Delete(id);
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
                var clientBll = new ClientBll();
                var listaDeClient = clientBll.ObterTodos();
                return Json(listaDeClient); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado


            }

        }


    }
}