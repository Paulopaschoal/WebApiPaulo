using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiPaulo.Models;
using WebApiPaulo.Repositorios;
using WebApiPaulo.Repositorios.Interfaces;

namespace WebApiPaulo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProtudoRepositorio _produtoRepositorio;

        public ProdutoController(IProtudoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }


        [HttpGet]
        public async Task<ActionResult<List<ProdutosModel>>> BuscarTodosProdutos()
        {
            List<ProdutosModel> produtos = await _produtoRepositorio.ObterTodosProtudos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutosModel>> BuscarPorId(int Id)
        {
            ProdutosModel produto = await _produtoRepositorio.ObteProdutoPorId(Id);
            return Ok(produto);
        }

        [HttpPost]  
        public async Task<ActionResult<ProdutosModel>> Adicionar([FromBody] ProdutosModel produtoModel)
        {
            ProdutosModel produto = await _produtoRepositorio.AdicionarProduto(produtoModel);
            return Ok(produto);
        }

        [HttpPut]
        public async Task<ActionResult<ProdutosModel>> Atualizar([FromBody] ProdutosModel produtosModel, int Id)
        {
            ProdutosModel produto = await _produtoRepositorio.AtualizarProduto(produtosModel, Id);
            return Ok(produto);

        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<ProdutosModel>> Apagar(int Id)
        {
            bool retorno = await _produtoRepositorio.DeletarProduto(Id);
            return Ok(retorno);
        }
    }
}
