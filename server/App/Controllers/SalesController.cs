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


        [HttpPost]
        public IActionResult Post([FromBody] SaleModelView saleModelView)
        {

            try
            {

                var saleBll = new SaleBll();
                saleBll.Inserir(saleModelView);
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }


        }




        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  SaleModelView saleModelView)
        {

            try
            {

                var saleBll = new SaleBll();
                saleBll.Atualizar(id, saleModelView);

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

                var saleBll = new SaleBll();
                var sale = saleBll.ObterPorId(id);

                return Json(sale);

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
                var saleBll = new SaleBll();
                saleBll.Delete(id);

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
                var saleBll = new SaleBll();
                var listaDeSale = saleBll.ObterTodos();
                return Json(listaDeSale);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }





    }
}