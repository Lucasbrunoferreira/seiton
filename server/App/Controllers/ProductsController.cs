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

    [Route("api/Products")]
    public class ProductsController : Controller
    {
        /// <summary>
        /// Essa rota é responsável por criar um Produto
        /// </summary>
        /// <param name="productModelView">Os dados necessário para criar um produto</param>
        /// <response code="201"> Sucesso ao criar um produto</response>
        /// <response code="422"> Erro ao criar um novo produto</response>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post([FromBody] ProductModelView productModelView)
        {

            try
            {

                var productBll = new ProductBll();
                productBll.Inserir(productModelView);
                return StatusCode(201, new { ProductBll = productBll }); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message }); //Exceções de negócio

            }
        }

        /// <summary>
        /// Essa rota é responsável por atualizar um Produto
        /// </summary>
        /// <param name="id">Atualizar produto</param>
        /// <param name="productModelView">Atualizar um Produto</param>
        /// <response code="204"> Sucesso ao atualizar o Produto </response>
        /// <response code="422"> Erro ao atualizar o Produto </response>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ProductModelView productModelView)
        {

            try
            {

                var productBll = new ProductBll();
                productBll.Atualizar(id, productModelView);
                return StatusCode(204, new { ProductBll = productBll}); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message}); //Exceções de negócio

            }

        }

        /// <summary>
        /// Essa rota é responsável por buscar um Produto
        /// </summary>
        /// <param name="id">Buscar um cliente já cadastrado</param>
        /// <response code="201"> Busca efetuada com sucesso </response>
        /// <response code="404"> Erro ao Buscar o Produto </response>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {

            try
            {

                var productBll = new ProductBll();
                var product = productBll.ObterPorId(id);
                return Json(product); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        /// Essa rota é responsável por deletar um Produto
        /// </summary>
        /// <param name="id">Deletar um produto já cadastrado</param>
        /// <response code="204"> Sucesso ao excluir Produto</response>
        /// <response code="404"> Erro ao deletar o Produto </response>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var productBll = new ProductBll();
                productBll.Delete(id);
                return StatusCode(204, new { ProductBll = productBll }); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }
        }

        /// <summary>
        /// Essa rota é responsável por buscar todos os Produtos já cadastrado
        /// </summary>
        /// <response code="201"> Busca efetuada com sucesso</response>
        /// <response code="404"> Erro ao Buscar o Produto </response>
        /// <returns></returns>

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var productBll = new ProductBll();
                var listaDeProduct = productBll.ObterTodos();
                return Json(listaDeProduct); //Recurso Encontrado mesmo que estege nulo
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        ///  Essa rota é responsável por retornar os Products atravez da data passa pelo parâmetro
        /// </summary>
        /// <param name="recuperaProdutoCadastrado">Os dados necessarios para buscar os Products</param>
        /// <response code="201"> Sucesso ao buscar um ProducSale</response>
        /// <response code="404"> Erro ao buscar um ProducSale</response>
        /// <returns>retorna um novo Client</returns>

        [HttpPost]
        [Route("retornarPorData")]
        public IActionResult PostComData([FromBody] RecuperaVenda recuperaProdutoCadastrado)
        {

            try
            {

                var productBll = new ProductBll();
                var product = productBll.RetornarPorData(recuperaProdutoCadastrado.dataVenda);

                return Json(product); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        /// Essa rota é responsável por controlar a quantidade Produtos no estoque que estão com menos de 100 unidades
        /// </summary>
        /// <response code="200"> Busca efetuada com sucesso</response>
        /// <response code="404"> Erro ao Buscar o Produto </response>
        /// <returns></returns>

        [HttpGet]
        [Route("buscarPorEstoqueAtencao")]
        public IActionResult GetByEstoqueAtencao()
        {

            try
            {
                var productBll = new ProductBll();
                var quantidade = productBll.ObterPorEstoqueAtencao();
                return StatusCode(200, new { Quantidade = quantidade}); //Recurso Encontrado mesmo que estege nulo
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new {Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        /// Essa rota é responsável por controlar a quantidade Produtos no estoque que estão com menos de 50 umidades
        /// </summary>
        /// <response code="200"> Busca efetuada com sucesso</response>
        /// <response code="404"> Erro ao Buscar o Produto </response>
        /// <returns></returns>

        [HttpGet]
        [Route("buscarPorEstoquePerigo")]
        public IActionResult GetByEstoquePerigo()
        {

            try
            {
                var productBll = new ProductBll();
                var quantidade = productBll.ObterPorEstoquePerigo();
                return StatusCode(200, new { Quantidade = quantidade }); //Recurso Encontrado mesmo que estege nulo
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

    }
}