using ControleOficina.Domain.Entities;
using ControleOficina.Domain.Enums;
using ControleOficina.Servicos.Context;
using ControleOficina.Servicos.Context.Seeding.Interfaces;

namespace ControleOficina.Cadastros.Context.SeedingService
{
    public class SeedingServico
    {
        public static void Seed(ApplicationContext dbcontext)
        {
            if (dbcontext.Servico.Any() ||
                dbcontext.PecaServico.Any())
            {
                return;
            }

            var s1 = new Servico()
            {
                Descricao = "Ajuste e reparo nos freios",
                Pecas = new List<PecaServico>
                { 
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Disco de freio").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 2,
                         DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo nos freios" && c.Veiculo.Modelo == "Fiesta")
                                .Select(c => c.Id).FirstOrDefault(),
                    },
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Pastilha de freio").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 2,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo nos freios" && c.Veiculo.Modelo == "Fiesta")
                                .Select(c => c.Id).FirstOrDefault()
                    }
                },
                FuncionarioId = dbcontext.Funcionario.Where(c => c.Nome == "Marcelo Vieira").Select(c => c.Id).FirstOrDefault(),
                Status = Status.Concluido,
                DataCriacao = DateTime.UtcNow, 
                DataFinalizacao = DateTime.UtcNow,
                VeiculoId = dbcontext.Veiculo.Where(c => c.Modelo == "Fiesta").Select(c => c.Id).FirstOrDefault(),
                ValorServico = (decimal)300.00
            };

            var s2 = new Servico()
            {
                Descricao = "Ajuste e reparo no escapamento",
                Pecas = new List<PecaServico>
                {
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Abafador").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 1,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo no escapamento" && c.Veiculo.Modelo == "Fiesta")
                                .Select(c => c.Id).FirstOrDefault()
                    },
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Catalisador").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 2,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo no escapamento" && c.Veiculo.Modelo == "Fiesta")
                                .Select(c => c.Id).FirstOrDefault()
                    }
                },
                FuncionarioId = dbcontext.Funcionario.Where(c => c.Nome == "Augusto José").Select(c => c.Id).FirstOrDefault(),
                Status = Status.Concluido,
                DataCriacao = DateTime.UtcNow,
                DataFinalizacao = DateTime.UtcNow,
                VeiculoId = dbcontext.Veiculo.Where(c => c.Modelo == "Fiesta").Select(c => c.Id).FirstOrDefault(),
                ValorServico = (decimal)300.00
            };

            var s3 = new Servico()
            {
                Descricao = "Ajuste e reparo na suspensão",
                Pecas = new List<PecaServico>
                {
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Amortecedor").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 2,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo na suspensão" && c.Veiculo.Modelo == "Gol")
                                .Select(c => c.Id).FirstOrDefault()
                    },
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Bucha Suspensão").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 4,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo na suspensão" && c.Veiculo.Modelo == "Gol")
                                .Select(c => c.Id).FirstOrDefault()
                    },
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Bieleta").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 2,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo na suspensão" && c.Veiculo.Modelo == "Gol")
                                .Select(c => c.Id).FirstOrDefault()
                    }
                },
                FuncionarioId = dbcontext.Funcionario.Where(c => c.Nome == "Renato Vieira").Select(c => c.Id).FirstOrDefault(),
                Status = Status.EmExecucao,
                DataCriacao = DateTime.UtcNow,
                DataFinalizacao = DateTime.UtcNow,
                VeiculoId = dbcontext.Veiculo.Where(c => c.Modelo == "Gol").Select(c => c.Id).FirstOrDefault(),
                ValorServico = (decimal)420.00
            };

            var s4 = new Servico()
            {
                Descricao = "Ajuste e reparo nos freios",
                Pecas = new List<PecaServico>
                {
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Bico injetor").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 4,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo nos freios" && c.Veiculo.Modelo == "Gol")
                                .Select(c => c.Id).FirstOrDefault()
                    } 
                },
                FuncionarioId = dbcontext.Funcionario.Where(c => c.Nome == "Augusto José").Select(c => c.Id).FirstOrDefault(),
                Status = Status.Concluido,
                DataCriacao = DateTime.UtcNow,
                DataFinalizacao = DateTime.UtcNow,
                VeiculoId = dbcontext.Veiculo.Where(c => c.Modelo == "Gol").Select(c => c.Id).FirstOrDefault(),
                ValorServico = (decimal)420.00
            };

            var s5 = new Servico()
            {
                Descricao = "Ajuste e reparo no escapamento",
                Pecas = new List<PecaServico>
                {
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Abafador").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 1,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo no escapamento" && c.Veiculo.Modelo == "Civic")
                                .Select(c => c.Id).FirstOrDefault()
                    },
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Catalisador").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 2,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparo no escapamento" && c.Veiculo.Modelo == "Civic")
                                .Select(c => c.Id).FirstOrDefault()
                    }
                },
                FuncionarioId = dbcontext.Funcionario.Where(c => c.Nome == "Marcelo Vieira").Select(c => c.Id).FirstOrDefault(),
                Status = Status.Concluido,
                DataCriacao = DateTime.UtcNow,
                DataFinalizacao = DateTime.UtcNow,
                VeiculoId = dbcontext.Veiculo.Where(c => c.Modelo == "Hilux").Select(c => c.Id).FirstOrDefault(),
                ValorServico = (decimal)300.00
            };

            var s6 = new Servico()
            {
                Descricao = "Ajuste e reparos gerais",
                Pecas = new List<PecaServico>
                {
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Correia dentada").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 1,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparos gerais" && c.Veiculo.Modelo == "Civic")
                                .Select(c => c.Id).FirstOrDefault()
                    },
                    new PecaServico()
                    {
                        PecaId = dbcontext.Peca.Where(c => c.Descricao == "Polia alternador").Select(c => c.Id).FirstOrDefault(),
                        Quantidade = 1,
                        DataCriacao = DateTime.UtcNow,
                        ServicoId = dbcontext.Servico.Where(c => c.Descricao == "Ajuste e reparos gerais" && c.Veiculo.Modelo == "Civic")
                                .Select(c => c.Id).FirstOrDefault()
                    }
                },
                FuncionarioId = dbcontext.Funcionario.Where(c => c.Nome == "Marcelo Vieira").Select(c => c.Id).FirstOrDefault(),
                Status = Status.EmExecucao,
                DataCriacao = DateTime.UtcNow,
                DataFinalizacao = DateTime.UtcNow,
                VeiculoId = dbcontext.Veiculo.Where(c => c.Modelo == "Civic").Select(c => c.Id).FirstOrDefault(),
                ValorServico = (decimal)300.00
            };

            dbcontext.Servico.AddRange(s1, s2, s3, s4, s5, s6);
            dbcontext.SaveChanges();
        }
    }
}
