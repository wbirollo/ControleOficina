using ControleOficina.Servicos.Context.Seeding.Interfaces;
using ControleOficina.Domain.Entities;

namespace ControleOficina.Servicos.Context.Seeding
{
    public class SeedingFuncionario 
    {
        public static void Seed(ApplicationContext dbcontext)
        {
            if (dbcontext.Funcionario.Any())
            {
                return;
            }

            var f1 = new Funcionario()
            {
                Nome = "Marcelo Vieira",
                NumeroTelefone = "19995978864",
                Cpf = "56489231525",
                Email = "marcelo@hotmail.com",
                Logradouro = "Avenida Amoreira",
                Numero = "674",
                Bairro = "Centro",
                Cidade = "Campinas",
                Estado = "SP",
                Pais = "Brasil",
                DataCriacao = DateTime.UtcNow
            };

            var f2 = new Funcionario()
            {
                Nome = "Augusto José",
                NumeroTelefone = "19987544552",
                Cpf = "23456123506",
                Email = "augusto@gmail.com",
                Logradouro = "Avenida dos Bandeirantes",
                Numero = "67",
                Bairro = "Vila Pires",
                Cidade = "Campinas",
                Estado = "SP",
                Pais = "Brasil",
                DataCriacao = DateTime.UtcNow
            };

            var f3 = new Funcionario()
            {
                Nome = "Renato Vieira",
                NumeroTelefone = "19993962456",
                Cpf = "54256898714",
                Email = "reanato@hotmail.com",
                Logradouro = "Avenida Amoreira",
                Numero = "674",
                Bairro = "Centro",
                Cidade = "Campinas",
                Estado = "SP",
                Pais = "Brasil",
                DataCriacao = DateTime.UtcNow
            };

            dbcontext.Funcionario.AddRange(f1, f2, f3);
            dbcontext.SaveChanges();
        }
    }
}
