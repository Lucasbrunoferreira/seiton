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
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }




        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  SaleModelView saleModelView)
        {

            try
            {

                var saleBll = new SaleBll();
                saleBll.Atualizar(id, saleModelView);
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




        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var saleBll = new SaleBll();
                saleBll.Delete(id);
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