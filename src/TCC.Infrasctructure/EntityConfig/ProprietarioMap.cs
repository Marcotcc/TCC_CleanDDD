using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.ApplicationCore.Entity;

namespace TCC.Infrasctructure.EntityConfig
{
    public class ProprietarioMap : IEntityTypeConfiguration<Proprietario>
    {
        public void Configure(EntityTypeBuilder<Proprietario> builder)
        {
            builder.ToTable("Proprietario");  

            builder.HasKey(proprietario => proprietario.ProprietarioId);

            builder.HasMany(proprietario => proprietario.Veiculos)
                .WithOne(veiculo => veiculo.Proprietario)
                .HasForeignKey(veiculo => veiculo.ProprietarioId)
                .HasPrincipalKey(proprietario => proprietario.ProprietarioId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
