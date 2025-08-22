using WebApiPaulo.Models;

namespace WebApiPaulo.Repositorios.Interfaces
{
    public interface IProtudoRepositorio
    {
        Task<List<ProdutosModel>> ObterTodosProtudos();
        Task<ProdutosModel> ObteProdutoPorId(int id);
        Task<ProdutosModel> AdicionarProduto(ProdutosModel produto);
        Task<ProdutosModel> AtualizarProduto(ProdutosModel produto, int id);
        Task<bool> DeletarProduto(int id);
    }
}
