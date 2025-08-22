using Microsoft.EntityFrameworkCore;
using WebApiPaulo.Data;
using WebApiPaulo.Models;
using WebApiPaulo.Repositorios.Interfaces;

namespace WebApiPaulo.Repositorios
{
    public class PedidoRepositorio : IPedidoRepositorio
    {

        private readonly SistemaVendasDBContext _DBContext;
        public PedidoRepositorio(SistemaVendasDBContext sistemaVendasDBContext)
        {

            _DBContext = sistemaVendasDBContext;
            // Aqui você pode inicializar o contexto do banco de dados ou qualquer outra configuração necessária.
        }
        public async Task<PedidoModel> AdicionarPedido(PedidoModel pedido)
        {
            _DBContext.Pedido.Add(pedido);
            _DBContext.SaveChanges();

            return pedido;
        }

        public async Task<PedidoModel> ObtePedidoPorId(int id)
        {
            return await _DBContext.Pedido.FirstOrDefaultAsync(c => c.IdPedido == id);
        }

        public async Task<List<PedidoModel>> ObterTodosPedidos()
        {
            return await _DBContext.Pedido.ToListAsync();
        }

        public async Task<PedidoModel> AtualizarPedido(PedidoModel pedido, int id)
        {
            PedidoModel PedidoPorId = await ObtePedidoPorId(id);
            if (PedidoPorId == null)
            {
                throw new Exception($"O pedido para o ID: {id} não foi encontrado no banco de dados.");
            }

            PedidoPorId.IdCliente = pedido.IdCliente;
            PedidoPorId.IdPedidoItem.IdProduto = pedido.IdPedidoItem.IdProduto;

            _DBContext.Pedido.Update(PedidoPorId);
            await _DBContext.SaveChangesAsync();
            return PedidoPorId;
        }

        public async Task<bool> DeletarPedido(int id)
        {
            PedidoModel PedidoPorId = await ObtePedidoPorId(id);
            if (PedidoPorId == null)
            {
                throw new Exception($"O pedido para o ID: {id} não foi encontrado no banco de dados.");
            }
            _DBContext.Pedido.Remove(PedidoPorId);
            await _DBContext.SaveChangesAsync();
            return true;
        }

     
    }
}
