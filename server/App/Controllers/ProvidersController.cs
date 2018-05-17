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

        /// <summary>
        /// Essa rota é responsável por criar um Fornecedor novo
        /// </summary>
        /// <param name="providerModelView">Os dados necessário para criar um fornecedor</param>
        /// <response code="201"> Sucesso ao criar um fornecedor</response>
        /// <response code="422"> Erro ao criar um novo fornecedor</response>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post([FromBody] ProviderModelView providerModelView)
        {

            try
            {

                var providerBll = new ProviderBll();
                providerBll.Inserir(providerModelView);
                return StatusCode(201, new { ProviderBll = providerBll}); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        /// <summary>
        /// Essa rota é responsável por atualizar um Fornecedor
        /// </summary>
        /// <param name="providerModelView">Os dados necessário para atualizar um fornecedor</param>
        /// <response code="204"> Sucesso ao atualizar um fornecedor</response>
        /// <response code="422"> Erro ao atualizar um fornecedor</response>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProviderModelView providerModelView)
        {

            try
            {

                var providerBll = new ProviderBll();
                providerBll.Atualizar(id, providerModelView);
                return StatusCode(204, new { ProviderBll = providerBll}); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }

        }

        /// <summary>
        /// Essa rota é responsável por buscar um Fornecedor
        /// </summary>
        /// <param name="id">Os dados necessário para buscar um fornecedor</param>
        /// <response code="201"> Sucesso ao buscar um fornecedor</response>
        /// <response code="404"> Erro ao buscar um fornecedor</response>
        /// <returns></returns>

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

        /// <summary>
        /// Essa rota é responsável por criar um Produto novo
        /// </summary>
        /// <param name="id">Os dados necessário para buscar um fornecedor</param>
        /// <response code="204"> Sucesso ao buscar um fornecedor</response>
        /// <response code="404"> Erro ao buscar um fornecedor</response>
        /// <returns></returns>

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

        /// <summary>
        /// Essa rota é responsável por bucar Fornecedor
        /// </summary>
        /// <response code="201"> Sucesso ao buscar um fornecedor</response>
        /// <response code="404"> Erro ao buscar um fornecedor</response>
        /// <returns></returns>

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