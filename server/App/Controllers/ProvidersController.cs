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
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProviderModelView providerModelView)
        {

            try
            {

                var providerBll = new ProviderBll();
                providerBll.Atualizar(id, providerModelView);

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

                var providerBll = new ProviderBll();
                var provider = providerBll.ObterPorId(id);

                return Json(provider);

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
                var providerBll = new ProviderBll();
                providerBll.Delete(id);

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
                var providerBll = new ProviderBll();
                var listaDeProvider = providerBll.ObterTodos();
                return Json(listaDeProvider);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }

    }
}