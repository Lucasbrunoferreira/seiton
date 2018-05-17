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

        /// <summary>
        /// Essa rota é responsável por criar uma LINE
        /// </summary>
        /// <param name="lineModelView"> Dados necessário para criar uma Line</param>
        /// <response code="201"> Sucesso ao criar uma Line</response>
        /// <response code="422"> Erro ao criar uma Line</response>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Post([FromBody] LineModelView lineModelView)
        {

            try
            {

                var lineBll = new LineBll();
                lineBll.Inserir(lineModelView);
                return StatusCode(201, new { LineBll = lineBll}); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message }); //Exceções de negócio

            }


        }

        /// <summary>
        /// Essa rota é responsável por atualizar uma Line
        /// </summary>
        /// <param name="id">Atualizar</param>
        /// <param name="lineModelView">Atualizar dados de uma Line</param>]
        /// <response code="204"> Sucesso ao atuzalizar a Line</response>
        /// <response code="422"> Erro ao atuzalizar a Line</response>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] LineModelView lineModelView)
        {

            try
            {

                var lineBll = new LineBll();
                lineBll.Atualizar(id, lineModelView);
                return StatusCode(204, new { LineBll = lineBll }); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message }); //Exceções de negócio

            }

        }

        /// <summary>
        /// Essa rota é responsável por Disponibilizar(Pegar) uma Line no banco
        /// </summary>
        /// <param name="id"> Disponibilizar dados de uma Line</param>
        /// <response code="201"> Line disponivél</response>
        /// <response code="404"> Erro buscar a Linha</response>
        /// <returns></returns>

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
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        /// Essa rota é responsável por deletar uma Line
        /// </summary>
        /// <param name="id"> Deletar Line</param>
        /// <response code="204"> Line excluida com sucesso</response>
        /// <response code="404"> Erro ao excluir Line</response>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var lineBll = new LineBll();
                lineBll.Delete(id);
                return StatusCode(204, new { LineBll = lineBll }); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }
        }

        /// <summary>
        /// Essa rota é responsável por Pegar(Selecionar) todas as Lines
        /// </summary>
        /// <response code="201"> Busca de Lines efetuada com sucesso</response>
        /// <response code="404"> Erro ao buscar Lines</response>
        /// <returns></returns>

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
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

    }
}