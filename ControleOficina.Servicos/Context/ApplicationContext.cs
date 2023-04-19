using ControleOficina.Domain.Entities;
using ControleOficina.Servicos.Context.Seeding.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ControleOficina.Servicos.Context
{
    public class ApplicationContext : DbContext
    {      
        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseNpgsql("Server=localhost;Port=5432;Database=db_controle;User Id=postgres;Password=123456789;");
            }
        }

        public DbSet<Servico> Servico { get; set; }
        public DbSet<Peca> Peca { get; set; }
        public DbSet<PecaServico> PecaServico { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
