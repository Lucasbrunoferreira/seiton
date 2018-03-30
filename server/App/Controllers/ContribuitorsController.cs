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
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ContribuitorModelView contribuitorModelView)
        {

            try
            {

                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Atualizar(id, contribuitorModelView);
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

                var contribuitorBll = new ContribuitorBll();
                var contribuitor = contribuitorBll.ObterPorId(id);
                return Json(contribuitor); //Recurso Encontrado mesmo que estege nulo;

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
                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Delete(id);
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
                var contribuitorBll = new ContribuitorBll();
                var listaDeContribuitor = contribuitorBll.ObterTodos();
                return Json(listaDeContribuitor); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

    }
}