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

    [Route("api/Products")]
    public class ProductsController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] ProductModelView productModelView)
        {

            try
            {

                var productBll = new ProductBll();
                productBll.Inserir(productModelView);
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }
        }



        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ProductModelView productModelView)
        {

            try
            {

                var productBll = new ProductBll();
                productBll.Atualizar(id, productModelView);
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

                var productBll = new ProductBll();
                var product = productBll.ObterPorId(id);
                return Json(product); //Recurso Encontrado mesmo que estege nulo;

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
                var productBll = new ProductBll();
                productBll.Delete(id);
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
                var productBll = new ProductBll();
                var listaDeProduct = productBll.ObterTodos();
                return Json(listaDeProduct); //Recurso Encontrado mesmo que estege nulo
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }




    }
}