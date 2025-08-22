using WebApiPaulo.Models;

namespace WebApiPaulo.Repositorios.Interfaces
{
    public interface IPedidoRepositorio
    {
        Task<List<PedidoModel>> ObterTodosPedidos();
        Task<PedidoModel> AdicionarPedido(PedidoModel pedido);
        Task<PedidoModel> ObtePedidoPorId(int id);
        Task<PedidoModel> AtualizarPedido(PedidoModel pedido, int id);
        Task<bool> DeletarPedido(int id);
    }
}
