using ControleOficina.Domain.Entities;
using ControleOficina.Servicos.Context.Seeding.Interfaces;

namespace ControleOficina.Servicos.Context.Seeding
{
    public class SeedingCliente 
    {
        public static void Seed(ApplicationContext dbcontext)
        {
            if (dbcontext.Cliente.Any())
            {
                return;
            }

            var c1 = new Cliente()
            {
                Nome = "Emerson Aparecido",
                NumeroTelefone = "19994567843",
                Cpf = "34567223412",
                Email = "emerson@gmail.com",
                Logradouro = "Rua João Oliveira",
                Numero = "11",
                Bairro = "Jardim Brasilia",
                Cidade = "Campinas",
                Estado = "SP",
                Pais = "Brasil",
                Veiculos = new List<Veiculo> { new Veiculo()
                {
                    Marca = "Ford",
                    Modelo = "Fiesta",
                    Ano = "2005",
                    Placa = "FGA2S12",
                    DataCriacao = DateTime.UtcNow,
                    ClienteId = dbcontext.Cliente.Where(c => c.Cpf == "34567223412").Select(c => c.Id).FirstOrDefault()
                }},
                DataCriacao = DateTime.UtcNow
            };

            var c2 = new Cliente()
            {
                Nome = "Gerson Ramos",
                NumeroTelefone = "19978905657",
                Cpf = "44435896312",
                Email = "gerson@gmail.com",
                Logradouro = "Rua Marcos Antonio",
                Numero = "126",
                Bairro = "Jardim Camilo",
                Cidade = "Campinas",
                Estado = "SP",
                Pais = "Brasil",
                Veiculos = new List<Veiculo> { new Veiculo()
                {
                    Marca = "Honda",
                    Modelo = "Civic",
                    Ano = "2010",
                    Placa = "HCC0V34",
                    DataCriacao = DateTime.UtcNow,
                    ClienteId = dbcontext.Cliente.Where(c => c.Cpf == "44435896312").Select(c => c.Id).FirstOrDefault()
                }},
                DataCriacao = DateTime.UtcNow
            };

            var c3 = new Cliente()
            {
                Nome = "Lucia da Silva",
                NumeroTelefone = "19987884542",
                Cpf = "66523148915",
                Email = "lucia@yahoo.com",
                Logradouro = "Avenida Brasil",
                Numero = "2050",
                Complemento = "Apartamento 33",
                Bairro = "Residencial das Flores",
                Cidade = "Campinas",
                Estado = "SP",
                Pais = "Brasil",
                Veiculos = new List<Veiculo> { new Veiculo()
                {
                    Marca = "Toyota",
                    Modelo = "Hilux",
                    Ano = "2015",
                    Placa = "FGH8J32",
                    DataCriacao = DateTime.UtcNow,
                    ClienteId = dbcontext.Cliente.Where(c => c.Cpf == "66523148915").Select(c => c.Id).FirstOrDefault()
                }},
                DataCriacao = DateTime.UtcNow
            };

            var c4 = new Cliente()
            {
                Nome = "José Silveira",
                NumeroTelefone = "19988638033",
                Cpf = "30230145678",
                Email = "jose@gmail.com",
                Logradouro = "Avenida Régis da Cunha",
                Numero = "305",
                Bairro = "Distrito Industrial",
                Cidade = "Campinas",
                Estado = "SP",
                Pais = "Brasil",
                Veiculos = new List<Veiculo> { new Veiculo()
                {
                    Marca = "VW",
                    Modelo = "Gol",
                    Ano = "2005",
                    Placa = "EDS2X34",
                    DataCriacao = DateTime.UtcNow,
                    ClienteId = dbcontext.Cliente.Where(c => c.Cpf == "30230145678").Select(c => c.Id).FirstOrDefault()
                }},
                DataCriacao = DateTime.UtcNow
            };

            dbcontext.Cliente.AddRange(c1, c2, c3, c4);
            dbcontext.SaveChanges();
        }
    }
}
