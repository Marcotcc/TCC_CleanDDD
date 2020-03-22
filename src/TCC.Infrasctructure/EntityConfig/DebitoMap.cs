using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.ApplicationCore.Entity;

namespace TCC.Infrasctructure.EntityConfig
{
    public class DebitoMap : IEntityTypeConfiguration<Debito>
    {
        public void Configure(EntityTypeBuilder<Debito> builder)
        {
            builder.ToTable("Debito");

            builder.HasKey(debito => debito.DebitoId);
        }
    }
}
