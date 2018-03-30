using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL;
using DAL.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sectors.App.Controllers
{

    [Route("api/Sectors")]
    public class SectorsController : Controller
    {

        [HttpPost]
        public IActionResult Post([FromBody] SectorModelView sectorModelView)
        {

            try
            {

                var sectorBll = new SectorBll();
                sectorBll.Inserir(sectorModelView);
                return StatusCode(201); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SectorModelView sectorModelView)
        {

            try
            {

                var sectorBll = new SectorBll();
                sectorBll.Atualizar(id, sectorModelView);
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

                var sectorBll = new SectorBll();
                var sector = sectorBll.ObterPorId(id);
                return Json(sector); //Recurso Encontrado mesmo que estege nulo;

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
                var sectorBll = new SectorBll();
                sectorBll.Delete(id);
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
                var sectorBll = new SectorBll();
                var listaDeSectors = sectorBll.ObterTodos();
                return Json(listaDeSectors); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }

        }

    }
}