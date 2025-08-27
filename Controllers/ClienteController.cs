using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPaulo.Models;
using WebApiPaulo.Repositorios.Interfaces;

namespace WebApiPaulo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteModel>>> BuscarTodosClientes()
        {
            List<ClienteModel> clientes = await _clienteRepositorio.ObterTodosClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClienteModel>> BuscarPorId(int Id)
        {
            ClienteModel cliente = await _clienteRepositorio.ObterClientePorId(Id);
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<ActionResult<ClienteModel>> Adicionar([FromBody] ClienteModel clienteModel)
        {
            ClienteModel cliente = await _clienteRepositorio.AdicionarCliente(clienteModel);
            return Ok(cliente);
        }

        [HttpPut]
        public async Task<ActionResult<ClienteModel>> Atualizar([FromBody] ClienteModel clienteModel, int Id)
        {
            ClienteModel cliente = await _clienteRepositorio.AtualizarCliente(clienteModel, Id);
            return Ok(cliente);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<ClienteModel>> Apagar(int Id)
        {
            bool retorno = await _clienteRepositorio.DeletarCliente(Id);


            return Ok(retorno);
        }

    }
}
