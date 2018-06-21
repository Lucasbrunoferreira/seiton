using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL;
using App.Models;
using DAL.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    
    [Route("api/ProductSales")]
    public class ProductSalesController : Controller
    {

        /// <summary>
        ///  Essa rota é responsável por criar um ProductSale
        /// </summary>
        /// <param name="productSaleModelView">Os dados necessarios para criar um novo ProducSale</param>
        /// <response code="201"> Sucesso ao criar um ProducSale</response>
        /// <response code="422"> Erro ao criar um novo ProducSale</response>
        /// <returns>retorna um novo Client</returns>
        
        [HttpPost]
        public IActionResult Post([FromBody] ProductSaleModelView productSaleModelView)
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                productSaleBll.Inserir(productSaleModelView);
                return StatusCode(201, new {ProductSaleBll = productSaleBll }); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }

        }

        /// <summary>
        ///  Essa rota é responsável por atualizar um ProductSale
        /// </summary>
        /// <param name="productSaleModelView">Os dados necessarios para atualizar um ProducSale</param>
        /// <response code="204"> Sucesso ao atualizar um ProducSale</response>
        /// <response code="422"> Erro ao atualizar um novo ProducSale</response>
        /// <returns>retorna um novo Client</returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ProductSaleModelView productSaleModelView)
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                productSaleBll.Atualizar(id, productSaleModelView);
                return StatusCode(204, new { ProductSaleBll = productSaleBll }); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }

        }

        /// <summary>
        ///  Essa rota é responsável por retornar um ProductSale
        /// </summary>
        /// <param name="id">Os dados necessarios para buscar um ProducSale</param>
        /// <response code="201"> Sucesso ao buscar um ProducSale</response>
        /// <response code="404"> Erro ao buscar um ProducSale</response>
        /// <returns>retorna um novo Client</returns>

        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                var productSale = productSaleBll.ObterPorId(id);

                return Json(productSale); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new {Erro = ex.Message}); //Recurso não Encontrado

            }

        }

        /// <summary>
        ///  Essa rota é responsável por retornar os ProductSales atravez da data passa pelo parâmetro
        /// </summary>
        /// <param name="recuperaVenda">Os dados necessarios para buscar os ProducSales</param>
        /// <response code="201"> Sucesso ao buscar um ProducSale</response>
        /// <response code="404"> Erro ao buscar um ProducSale</response>
        /// <returns>retorna um novo Client</returns>

        [HttpPost]
        [Route("retornarPorData")]
        public IActionResult PostComData([FromBody] RecuperaVenda recuperaVenda)
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                var productSale = productSaleBll.RetornarPorData(recuperaVenda.dataVenda);

                return Json(productSale); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        ///  Essa rota é responsável por retornar os ProductSales atravez da data atual
        /// </summary>
        /// <response code="201"> Sucesso ao buscar um ProducSale</response>
        /// <response code="404"> Erro ao buscar um ProducSale</response>
        /// <returns>retorna um novo Client</returns>

        [HttpPost]
        [Route("retornarPorDataAtual")]
        public IActionResult PostComDataAtual()
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                var productSale = productSaleBll.RetornarPorDataAtual(DateTime.Today);

                return Json(productSale); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        ///  Essa rota é responsável por deletar um ProductSale
        /// </summary>
        /// <param name="id">Os dados necessarios para deletar um ProducSale</param>
        /// <response code="204"> Sucesso ao deletar um ProducSale</response>
        /// <response code="404"> Erro ao deletar um ProducSale</response>
        /// <returns>retorna um novo Client</returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var productSaleBll = new ProductSaleBll();
                productSaleBll.Delete(id);
                return StatusCode(204, new { ProductSaleBll = productSaleBll }); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }
        }

        /// <summary>
        ///  Essa rota é responsável por retornar ProductSale
        /// </summary>
        /// <response code="201"> Sucesso ao buscar ProducSale</response>
        /// <response code="404"> Erro ao buscar ProducSale</response>
        /// <returns>retorna um novo Client</returns>

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var productSaleBll = new ProductSaleBll();
                var listaDeProductSale = productSaleBll.ObterTodos();
                return Json(listaDeProductSale); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }





    }
}