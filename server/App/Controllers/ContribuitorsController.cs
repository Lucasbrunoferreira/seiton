using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL;
using App.Models;
using BLL;
using DAL.ModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
 
    [Route("api/Contribuitors")]
    public class ContribuitorsController : Controller
    {

        /// <summary>
        /// Essa rota é reponsável por adicionar um novo contribuidor
        /// </summary>
        /// <param name="contribuitorModelView"> Os dados necessário para criar um novo contribuidor</param>
        /// <response code="201"> Sucesso ao criar um Contribuidor</response>
        /// <response code="422"> Erro ao criar um novo Contribuidor</response>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] ContribuitorModelView contribuitorModelView)
        {

            try
            {

                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Inserir(contribuitorModelView);
                return StatusCode(201, new {ContribuitorBll = contribuitorBll }); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422); //Exceções de negócio

            }


        }

        /// <summary>
        /// Essa rota é resposável por Controlar meus contribuidores do sistema 
        /// </summary>
        /// <param name="loginModel"> Dados necessário para fazer Login no sistema</param>
        /// <response code="201"> Login efetuado com sucesso</response>
        /// <response code="422"> Erro ao efetuar o Login</response>
        /// <returns></returns>

        [HttpPost]
        [Route("login")]
        public IActionResult PostLogin([FromBody] LoginModel loginModel)
        {

            try
            {

                var contribuitorBll = new ContribuitorBll();
                var contribuitor = contribuitorBll.Login(loginModel.Usuario, loginModel.Senha);
                return StatusCode(200, contribuitor); //Postado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message }); //Exceções de negócio

            }


        }

        /// <summary>
        /// Essa rota é resposavel por Atualizar um Contribuidor
        /// </summary>
        /// <param name="id"> Rota responsavel por alterar dodos de um contribuidor.</param>
        /// <param name="contribuitorModelView"></param>
        /// <response code="201"> Contribuidor atualizado com Sucesso.</response>
        /// <response code="422"> Erro ao atualizar.</response>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]  ContribuitorModelView contribuitorModelView)
        {

            try
            {

                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Atualizar(id, contribuitorModelView);
                return StatusCode(204, new { ContribuitorBll = contribuitorBll }); //Indica que o recurso foi alterado com sucesso

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(422, new { Erro = ex.Message }); //Exceções de negócio

            }

        }

        /// <summary>
        /// Essa rota é responsável por disponibilizar(Pegar) contribuidor no banco
        /// </summary>
        /// <param name="id"> Rota responsável por buscar dados de um contribuidor no banco</param>
        /// <response code="201"> Busca efetuada com Sucesso</response>
        /// <response code="422"> Erro ao disponibilizar contribuidor</response>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetComId(int id)
        {

            try
            {

                var contribuitorBll = new ContribuitorBll();
                var contribuitor = contribuitorBll.ObterPorId(id);
                return Json(contribuitor); //Recurso Encontrado mesmo que estege nulo;

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

        /// <summary>
        /// Essa rota é responsável por deletar um Contribuidor
        /// </summary>
        /// <param name="id"> Deletar contribuidor</param>
        /// <response code="201"> Contribuido deletado com sucesso</response>
        /// <response code="422"> Erro ao deletar contribuidor</response>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var contribuitorBll = new ContribuitorBll();
                contribuitorBll.Delete(id);
                return StatusCode(204, new { ContribuitorBll = contribuitorBll }); //Indica que o recurso foi excluído com sucesso

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }
        }

        /// <summary>
        /// Essa rota é responsável por buscar todos os contribuidores no banco
        /// </summary>
        /// <response code="422"> Erro ao buscar clientes</response>
        /// <returns></returns>

        [HttpGet]
        public IActionResult GetAll()
        {

            try
            {
                var contribuitorBll = new ContribuitorBll();
                var listaDeContribuitor = contribuitorBll.ObterTodos();
                return Json(listaDeContribuitor); //Recurso Encontrado mesmo que estege nulo

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return StatusCode(404, new { Erro = ex.Message }); //Recurso não Encontrado

            }

        }

    }
}