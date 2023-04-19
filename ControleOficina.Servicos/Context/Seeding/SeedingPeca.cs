using ControleOficina.Servicos.Context.Seeding.Interfaces;
using ControleOficina.Domain.Entities;

namespace ControleOficina.Servicos.Context.Seeding
{
    public class SeedingPeca 
    {
        public static void Seed(ApplicationContext dbcontext)
        {
            if(dbcontext.Peca.Any())
            {
                return;
            }

            var p1 = new Peca()
            {
                Descricao = "Disco de freio",
                ValorUnitario = (decimal)150.00,
                DataCriacao = DateTime.UtcNow
            };

            var p2 = new Peca()
            {
                Descricao = "Amortecedor",
                ValorUnitario = (decimal)250.00,
                DataCriacao = DateTime.UtcNow
            };

            var p3 = new Peca()
            {
                Descricao = "Bico injetor",
                ValorUnitario = (decimal)75.00,
                DataCriacao = DateTime.UtcNow
            };

            var p4 = new Peca()
            {
                Descricao = "Vela",
                ValorUnitario = (decimal)40.00,
                DataCriacao = DateTime.UtcNow
            };

            var p5 = new Peca()
            {
                Descricao = "Catalisador",
                ValorUnitario = (decimal)500.00,
                DataCriacao = DateTime.UtcNow
            };

            var p6 = new Peca()
            {
                Descricao = "Pastilha de freio",
                ValorUnitario = (decimal)80.00,
                DataCriacao = DateTime.UtcNow
            };

            var p7 = new Peca()
            {
                Descricao = "Bucha Suspensão",
                ValorUnitario = (decimal)70.00,
                DataCriacao = DateTime.UtcNow
            };

            var p8 = new Peca()
            {
                Descricao = "Bieleta",
                ValorUnitario = (decimal)200.00,
                DataCriacao = DateTime.UtcNow
            };

            var p9 = new Peca()
            {
                Descricao = "Correia dentada",
                ValorUnitario = (decimal)120.00,
                DataCriacao = DateTime.UtcNow
            };

            var p10 = new Peca()
            {
                Descricao = "Polia alternador",
                ValorUnitario = (decimal)130.00,
                DataCriacao = DateTime.UtcNow
            };

            var p11 = new Peca()
            {
                Descricao = "Abafador",
                ValorUnitario = (decimal)200.00,
                DataCriacao = DateTime.UtcNow
            };

            dbcontext.Peca.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            dbcontext.SaveChanges();
        }
    }
}
