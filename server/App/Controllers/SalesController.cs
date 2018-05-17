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

    [Route("api/Sales")]
    public class SalesController : Controller
    {

        /// <summary>
        /// Essa rota é responsável por criar uma Venda
        /// </summary>
        /// <param name="saleModelView">Os dados necessário para criar uma venda</param>
        /// <response code="201"> Sucesso ao criar uma venda</response>
        /// <response code="422"> Erro ao criar uma venda</response>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post([FromBody] SaleModelView saleModelView)
        {

            try
            {

                var saleBll = new SaleBll();
                saleBll.Inserir(saleModelView);
                return StatusCode(201, new { SaleBll = saleBll }); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        /// <summary>
        /// Essa rota é responsável por atualizar uma Venda
        /// </summary>
        /// <param name="saleModelView">Os dados necessário para atualizar uma venda</param>
        /// <response code="204"> Sucesso ao atualizar uma venda</response>
        /// <response code="422"> Erro ao atualizar uma venda</response>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  SaleModelView saleModelView)
        {

            try
            {

                var saleBll = new SaleBll();
                saleBll.Atualizar(id, saleModelView);
                return StatusCode(204, new { SaleBll = saleBll }); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }

        }

        /// <summary>
        /// Essa rota é responsável por buscar uma Venda
        /// </summary>
        /// <param name="id">Os dados necessário para buscar uma venda</param>
        /// <response code="201"> Sucesso ao buscar uma venda</response>
        /// <response code="404"> Erro ao buscar uma venda</response>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {

            try
            {

                var saleBll = new SaleBll();
                var sale = saleBll.ObterPorId(id);
                return Json(sale); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

        /// <summary>
        /// Essa rota é responsável por buscar uma Venda
        /// </summary>
        /// <param name="id">Os dados necessário para buscar uma venda</param>
        /// <response code="201"> Sucesso ao buscar uma venda</response>
        /// <response code="404"> Erro ao buscar uma venda</response>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var saleBll = new SaleBll();
                saleBll.Delete(id);
                return StatusCode(204, new {SaleBll = saleBll }); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }
        }

        /// <summary>
        /// Essa rota é responsável por buscar uma Venda
        /// </summary>
        /// <param name="id">Os dados necessário para buscar uma venda</param>
        /// <response code="201"> Sucesso ao buscar uma venda</response>
        /// <response code="404"> Erro ao buscar uma venda</response>
        /// <returns></returns>

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var saleBll = new SaleBll();
                var listaDeSale = saleBll.ObterTodos();
                return Json(listaDeSale); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

    }
}