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
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }
        }



        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ProductModelView productModelView)
        {

            try
            {

                var productBll = new ProductBll();
                productBll.Atualizar(id, productModelView);

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

                var productBll = new ProductBll();
                var product = productBll.ObterPorId(id);

                return Json(product);

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
                var productBll = new ProductBll();
                productBll.Delete(id);

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
                var productBll = new ProductBll();
                var listaDeProduct = productBll.ObterTodos();
                return Json(listaDeProduct);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }




    }
}