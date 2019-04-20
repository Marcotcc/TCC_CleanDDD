using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.ApplicationCore.Entity;

namespace TCC.Infrasctructure.EntityConfig
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");  

            builder.HasKey(cliente => cliente.ClienteId);

            builder.HasMany(cliente => cliente.Veiculos)
                .WithOne(veiculo => veiculo.Cliente)
                .HasForeignKey(veiculo => veiculo.ClienteId)
                .HasPrincipalKey(cliente => cliente.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
