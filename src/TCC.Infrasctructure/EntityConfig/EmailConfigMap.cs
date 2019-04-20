using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TCC.ApplicationCore.Entity;

namespace TCC.Infrasctructure.EntityConfig
{
    public class EmailConfigMap : IEntityTypeConfiguration<EmailConfig>
    {
        public void Configure(EntityTypeBuilder<EmailConfig> builder)
        {
            builder.ToTable("EmailConfig");

            builder.HasKey(emailConfig => emailConfig.EmailConfigId);
        }
    }
}
