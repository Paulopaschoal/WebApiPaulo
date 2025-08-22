using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiPaulo.Models;

namespace WebApiPaulo.Data.Map
{
    public class PedidoMap : IEntityTypeConfiguration<PedidoModel>
    {
        public void Configure(EntityTypeBuilder<PedidoModel> builder)
        {
            builder.HasKey(x => x.IdPedido);
            builder.Property(x => x.IdPedido)
                .HasColumnName("IdPedido")
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(x => x.IdCliente)
                .HasColumnName("IdCliente")
                .IsRequired();
            builder.Property(x => x.IdProduto)
                .HasColumnName("IdProduto")
                .IsRequired(false);
            //builder.HasOne(x => x.IdPedidoItem).WithOne().HasForeignKey<PedidoItem>(x => x.IdPedidoItem);
            builder.ToTable("Pedido");
        }
    }
}
