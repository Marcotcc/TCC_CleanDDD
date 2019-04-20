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

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<EmailConfig> EmaiilConfig { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().ToTable("Veiculo");
            modelBuilder.Entity<EmailConfig>().ToTable("EmailConfig");

            modelBuilder.ApplyConfiguration(new ClienteMap());
        }
    }
}
