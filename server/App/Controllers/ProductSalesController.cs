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
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }

        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ProductSaleModelView productSaleModelView)
        {

            try
            {

                var productSaleBll = new ProductSaleBll();
                productSaleBll.Atualizar(id, productSaleModelView);
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

                var productSaleBll = new ProductSaleBll();
                var productSale = productSaleBll.ObterPorId(id);

                return Json(productSale); //Recurso Encontrado mesmo que estege nulo;

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
                var productSaleBll = new ProductSaleBll();
                productSaleBll.Delete(id);
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