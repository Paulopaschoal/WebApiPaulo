using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiPaulo.Models;

namespace WebApiPaulo.Data.Map
{
    public class ClienteMap : IEntityTypeConfiguration<ClienteModel>
    {
        public void Configure(EntityTypeBuilder<ClienteModel> builder)
        {
           builder.HasKey(x => x.IdCliente);
            builder.Property(x => x.IdCliente)
                .HasColumnName("IdCliente")
                .IsRequired()
                .ValueGeneratedOnAdd();
            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .IsRequired()
                .HasMaxLength(100);
            builder.ToTable("Cliente");
        }
    }
}
