using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPaulo.Models;

namespace WebApiPaulo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ClienteModel>> BuscarTodosClientes()
        {
            return Ok("todos os clientes");
        }
    }
}
