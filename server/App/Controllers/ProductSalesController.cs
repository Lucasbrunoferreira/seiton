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
    
    [Route("api/ProductSales")]
    public class ProductSalesController : Controller
    {


        [HttpPost]
        public IActionResult Post([FromBody] ProductSaleModelView productSaleModelView)
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                productSaleBll.Inserir(productSaleModelView);
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ProductSaleModelView productSaleModelView)
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                productSaleBll.Atualizar(id, productSaleModelView);

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

                var productSaleBll = new ProductSaleBll();
                var productSale = productSaleBll.ObterPorId(id);

                return Json(productSale);

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
                var productSaleBll = new ProductSaleBll();
                productSaleBll.Delete(id);

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
                var productSaleBll = new ProductSaleBll();
                var listaDeProductSale = productSaleBll.ObterTodos();
                return Json(listaDeProductSale);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }





    }
}