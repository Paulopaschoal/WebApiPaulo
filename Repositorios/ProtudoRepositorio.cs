using Microsoft.EntityFrameworkCore;
using WebApiPaulo.Data;
using WebApiPaulo.Models;
using WebApiPaulo.Repositorios.Interfaces;

namespace WebApiPaulo.Repositorios
{
    public class ProtudoRepositorio : IProtudoRepositorio
    {
        private readonly SistemaVendasDBContext _DBContext;
        public ProtudoRepositorio(SistemaVendasDBContext sistemaVendasDBContext)
        {

            _DBContext = sistemaVendasDBContext;
            // Aqui você pode inicializar o contexto do banco de dados ou qualquer outra configuração necessária.
        }
        public async Task<ProdutosModel> AdicionarProduto(ProdutosModel produto)
        {
            _DBContext.Produtos.Add(produto);
            _DBContext.SaveChanges();

            return produto;
        }

        public async Task<ProdutosModel> ObteProdutoPorId(int id)
        {
            return await _DBContext.Produtos.FirstOrDefaultAsync(c => c.IdProduto == id);
        }

        public async Task<ProdutosModel> AtualizarProduto(ProdutosModel produto, int id)
        {
            ProdutosModel ProdutoporId = await ObteProdutoPorId(id);
            if (ProdutoporId == null)
            {
                throw new Exception($"O produto para o ID: {id} não foi encontrado no banco de dados.");
            }

            ProdutoporId.Nome = produto.Nome;
            ProdutoporId.Preco = produto.Preco;
            ProdutoporId.Estoque = produto.Estoque;
            _DBContext.Produtos.Update(ProdutoporId);
            await _DBContext.SaveChangesAsync();
            return ProdutoporId;
        }

        public async Task<bool> DeletarProduto(int id)
        {
            ProdutosModel ProdutoporId = await ObteProdutoPorId(id);
            if (ProdutoporId == null)
            {
                throw new Exception($"O produto para o ID: {id} não foi encontrado no banco de dados.");
            }
            _DBContext.Produtos.Remove(ProdutoporId);
            await _DBContext.SaveChangesAsync();
            return true;
        }

      

        public async Task<List<ProdutosModel>> ObterTodosProtudos()
        {
            return await _DBContext.Produtos.ToListAsync();
        }
    }
}
