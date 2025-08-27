using Microsoft.EntityFrameworkCore;
using WebApiPaulo.Data;
using WebApiPaulo.Models;
using WebApiPaulo.Repositorios.Interfaces;

namespace WebApiPaulo.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly SistemaVendasDBContext _DBContext;
        public ClienteRepositorio(SistemaVendasDBContext context)
        {

            _DBContext = context;
            // Aqui você pode inicializar o contexto do banco de dados ou qualquer outra configuração necessária.
        }
 
        public async Task<ClienteModel> AdicionarCliente(ClienteModel cliente)
        {
            _DBContext.Cliente.Add(cliente);
            _DBContext.SaveChanges();

            return cliente;
        }

        public async Task<ClienteModel> AtualizarCliente(ClienteModel cliente, int id)
        {
            ClienteModel UsuarioporId = await ObterClientePorId(id);
            if (UsuarioporId == null)
            {
                throw new Exception($"Cliente para o ID: {id} não foi encontrado no banco de dados.");
            }

            UsuarioporId.Nome = cliente.Nome;
            UsuarioporId.Email = cliente.Email;
            _DBContext.Cliente.Update(UsuarioporId);
            await _DBContext.SaveChangesAsync();
            return UsuarioporId;

        }

        public async Task<bool> DeletarCliente(int id)
        {
            ClienteModel UsuarioporId = await ObterClientePorId(id);
            if (UsuarioporId == null)
            {
                throw new Exception($"Cliente para o ID: {id} não foi encontrado no banco de dados.");
            }
            _DBContext.Cliente.Remove(UsuarioporId);
            await _DBContext.SaveChangesAsync();
            return true;
        }

        public async Task<ClienteModel> ObterClientePorId(int id)
        {
            var cliente = await _DBContext.Cliente.FirstOrDefaultAsync(c => c.IdCliente == id);
            if (cliente == null)
            {
                throw new Exception($"Cliente para o ID: {id} não foi encontrado no banco de dados.");
            }
            return cliente;
        }

        public async Task<List<ClienteModel>> ObterTodosClientes()
        {
            return await _DBContext.Cliente.ToListAsync();
        }
    }
}
