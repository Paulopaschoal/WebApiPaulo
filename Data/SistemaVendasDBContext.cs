using Microsoft.EntityFrameworkCore;
using WebApiPaulo.Models;

namespace WebApiPaulo.Data
{
    public class SistemaVendasDBContext : DbContext
    {
        public SistemaVendasDBContext(DbContextOptions<SistemaVendasDBContext> options)
            : base(options)
        {
        }
 
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<ProdutosModel> Produtos { get; set; }
        public DbSet<PedidoModel> Pedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais do modelo, se necessário
            base.OnModelCreating(modelBuilder);
        }
    }
}
