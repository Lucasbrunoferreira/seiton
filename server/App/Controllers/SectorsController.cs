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
                return NoContent();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }


        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SectorModelView sectorModelView)
        {

            try
            {

                var sectorBll = new SectorBll();
                sectorBll.Atualizar(id, sectorModelView);

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

                var sectorBll = new SectorBll();
                var sector = sectorBll.ObterPorId(id);

                return Json(sector);

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
                var sectorBll = new SectorBll();
                sectorBll.Delete(id);

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
                var sectorBll = new SectorBll();
                var listaDeSectors = sectorBll.ObterTodos();
                return Json(listaDeSectors);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(500);

            }

        }

    }
}