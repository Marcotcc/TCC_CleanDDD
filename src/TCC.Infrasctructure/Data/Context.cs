using Microsoft.EntityFrameworkCore;
using TCC.ApplicationCore.Entity;
using TCC.Infrasctructure.EntityConfig;

namespace TCC.Infrasctructure.Data
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<EmailConfig> EmaiilConfig { get; set; }
        public DbSet<Debito> Debitos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProprietarioMap());
            modelBuilder.ApplyConfiguration(new VeiculoMap());
            modelBuilder.ApplyConfiguration(new EmailConfigMap());
            modelBuilder.ApplyConfiguration(new DebitoMap());
        }
    }
}
