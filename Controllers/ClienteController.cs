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

    }
}
