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

        /// <summary>
        /// Essa rota é responsável por criar um Setor
        /// </summary>
        /// <param name="sectorModelView">Os dados necessário para criar um setor</param>
        /// <response code="201"> Sucesso ao criar um setor</response>
        /// <response code="422"> Erro ao criar um setor</response>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post([FromBody] SectorModelView sectorModelView)
        {

            try
            {

                var sectorBll = new SectorBll();
                sectorBll.Inserir(sectorModelView);
                return StatusCode(201, new { SectorBll = sectorBll}); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        /// <summary>
        /// Essa rota é responsável por atualizar um Setor
        /// </summary>
        /// <param name="sectorModelView">Os dados necessário para atualizar um setor</param>
        /// <response code="201"> Sucesso ao atualizar um setor</response>
        /// <response code="422"> Erro ao atualizar um setor</response>
        /// <returns></returns>

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

        /// <summary>
        /// Essa rota é responsável por buscar um Setor
        /// </summary>
        /// <param name="id">Os dados necessário para buscar um setor</param>
        /// <response code="201"> Sucesso ao buscar um setor</response>
        /// <response code="404"> Erro ao buscar um setor</response>
        /// <returns></returns>

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

        /// <summary>
        /// Essa rota é responsável por deletar um Setor
        /// </summary>
        /// <param name="id">Os dados necessário para deletar um setor</param>
        /// <response code="204"> Sucesso ao deletar um setor</response>
        /// <response code="404"> Erro ao deletar um setor</response>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var sectorBll = new SectorBll();
                sectorBll.Delete(id);
                return StatusCode(204, new { SectorBll = sectorBll}); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404); //Recurso não Encontrado

            }
        }

        /// <summary>
        /// Essa rota é responsável por buscar Setor
        /// </summary>
        /// <param name="id">Os dados necessário para buscar um setor</param>
        /// <response code="201"> Sucesso ao buscar setor</response>
        /// <response code="404"> Erro ao buscasr setor</response>
        /// <returns></returns>

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