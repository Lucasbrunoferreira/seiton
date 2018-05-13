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

    [Route("api/Clients")]
    public class ClientsController : Controller
    {

        /// <summary>
        ///  Essa rota é responsável por criar um cliente
        /// </summary>
        /// <param name="clientModelView">Os dados necessarios para criar um novo cliente</param>
        /// <response code="201"> Sucesso ao criar um cliente</response>
        /// <response code="422"> Erro ao criar um novo Client</response>
        /// <returns>retorna um novo Client</returns>
        [HttpPost]
        public IActionResult Post([FromBody] ClientModelView clientModelView)
        {

            try
            {

                var clientBll = new ClientBll();
                clientBll.Inserir(clientModelView);
                return StatusCode(201, new {ClientBll = clientBll }); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message }); //Exceções de negócio

            }

        }


        /// <summary>
        /// Essa rota é responsavel por atualizar os dados de um client existente;
        /// </summary>
        /// <param name="id"> Atualizar um cliente</param>
        /// <param name="clientModelView"> Dados a serem atualizados </param>
        /// <response code="204"> No Content </response>
        /// <response code="422"> Erro ao atualizar os dados </response>
        /// <returns> no content </returns>
        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ClientModelView clientModelView)
        {

            try
            {

                var clientBll = new ClientBll();
                clientBll.Atualizar(id, clientModelView);
                return StatusCode(204, new { ClientBll = clientBll }); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message }); //Exceções de negócio

            }

        }

        /// <summary>
        /// Essa rota é responsável por disponibilizar(Pegar) cliente no banco
        /// </summary>
        /// <param name="id"> Rota é responsável disponibilizar um cliente</param>
        /// <param name="clientModelView">Disponibilizar(Pegar), dados de cliente</param>
        /// <response code="201"> Busca efetuada com Sucesso</response>
        /// <response code="422"> Erro ao disponinilizar os dados do cliente</response>
        /// <returns></returns>


        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {

            try
            {

                var clientBll = new ClientBll();
                var client = clientBll.ObterPorId(id); //Recurso Encontrado mesmo que estege nulo;
                return Json(client);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        /// Essa rota é responsável por deletar(excluir), um cliente
        /// </summary>
        /// <param name="id"> Excluir um cliente</param>
        /// <param name="clientModelView"> Deletar um cliente</param>
        /// <response code="204"> Exclusão efetuada com sucesso</response>
        /// <response code="404"> Erro ao deletar</response>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var clientBll = new ClientBll();
                clientBll.Delete(id);
                return StatusCode(204, new { ClientBll = clientBll }); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }
        }

        /// <summary>
        ///  Essa Rota é repolsável por Pegar(Selecionar), todos os clientes 
        /// </summary>
        /// <param name="listaDeClient"> Selecionar todos os clientes</param>
        /// <response code="201"> Clientes selecionado com sucesso</response>
        /// <response code="404"> Erro ao selecionar os Clientes</response>
        /// <returns></returns>

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var clientBll = new ClientBll();
                var listaDeClient = clientBll.ObterTodos();
                return Json(listaDeClient); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

    }
}