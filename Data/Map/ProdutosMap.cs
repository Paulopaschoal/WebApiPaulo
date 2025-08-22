using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiPaulo.Models;

namespace WebApiPaulo.Data.Map
{
    public class ProdutosMap : IEntityTypeConfiguration<ProdutosModel>
    {
        public void Configure(EntityTypeBuilder<ProdutosModel> builder)
        {
            builder.HasKey(x => x.IdProduto);
            builder.Property(x => x.IdProduto)
                .HasColumnName("IdProduto")
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Preco)
              .HasColumnName("Preco");
            builder.Property(x => x.Estoque)
           .HasColumnName("Estoque");


        }
    }
}
