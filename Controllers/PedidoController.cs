using Microsoft.AspNetCore.Mvc;
using WebApiPaulo.Models;
using WebApiPaulo.Repositorios.Interfaces;

namespace WebApiPaulo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepositorio _pedidoRepositorio;

        public PedidoController(IPedidoRepositorio pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;
        }

        [HttpGet]   
        public async Task<ActionResult<List<PedidoModel>>> BuscarTodosPedidos()
        {
            List<PedidoModel> pedidos = await _pedidoRepositorio.ObterTodosPedidos();
            return Ok(pedidos);
        }
    }


}
