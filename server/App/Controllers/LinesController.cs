using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL;
using DAL.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lines.App.Controllers
{
   
    [Route("api/Lines")]
    public class LinesController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] LineModelView lineModelView)
        {

            try
            {

                var lineBll = new LineBll();
                lineBll.Inserir(lineModelView);
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] LineModelView lineModelView)
        {

            try
            {

                var lineBll = new LineBll();
                lineBll.Atualizar(id, lineModelView);
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

                var lineBll = new LineBll();
                var line = lineBll.ObterPorId(id);
                return Json(line); //Recurso Encontrado mesmo que estege nulo;

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
                var lineBll = new LineBll();
                lineBll.Delete(id);
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
                var lineBll = new LineBll();
                var listaDeLines= lineBll.ObterTodos();
                return Json(listaDeLines); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

    }
}