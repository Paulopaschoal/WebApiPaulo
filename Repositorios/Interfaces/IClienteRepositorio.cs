using WebApiPaulo.Models;

namespace WebApiPaulo.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> ObterTodosClientes();
        Task<ClienteModel> ObterClientePorId(int id);
        Task<ClienteModel> AdicionarCliente(ClienteModel cliente);
        Task<ClienteModel> AtualizarCliente(ClienteModel cliente, int id);
        Task<bool> DeletarCliente(int id);
    }
}
