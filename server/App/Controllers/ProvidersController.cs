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
   
    [Route("api/Providers")]
    public class ProvidersController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] ProviderModelView providerModelView)
        {

            try
            {

                var providerBll = new ProviderBll();
                providerBll.Inserir(providerModelView);
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProviderModelView providerModelView)
        {

            try
            {

                var providerBll = new ProviderBll();
                providerBll.Atualizar(id, providerModelView);
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

                var providerBll = new ProviderBll();
                var provider = providerBll.ObterPorId(id);
                return Json(provider); //Recurso Encontrado mesmo que estege nulo;

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
                var providerBll = new ProviderBll();
                providerBll.Delete(id);
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
                var providerBll = new ProviderBll();
                var listaDeProvider = providerBll.ObterTodos();
                return Json(listaDeProvider); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

    }
}