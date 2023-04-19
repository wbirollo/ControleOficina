using ControleOficina.Domain.DTOs;
using ControleOficina.Domain.Entities;
using ControleOficina.Domain.Enums;
using ControleOficina.Servicos.Context;
using ControleOficina.Servicos.Mappers.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleOficina.Servicos.Mappers
{
    public class ServicoMapper : IServicoMapper
    {
        private readonly ApplicationContext _context;

        public ServicoMapper(ApplicationContext context)
        {
            _context = context;
        }

        public Servico ToNewEntity(ServicoDTO dto)
        {
            var pecas = new List<PecaServico>();

            foreach (var item in dto.Pecas)
            {
                pecas.Add(new PecaServico()
                {
                    PecaId = _context.Peca.Where(c => c.Descricao == item.Peca.Descricao).Select(c => c.Id).FirstOrDefault(),
                    Quantidade = item.Quantidade,
                    DataCriacao = DateTime.UtcNow
                });
            }

            var funcionario = _context.Funcionario.FirstOrDefaultAsync(c => c.Cpf == dto.Funcionario.Cpf).GetAwaiter().GetResult();

            var veiculo = _context.Veiculo.Include(c => c.Cliente).FirstOrDefaultAsync(c => c.Placa == dto.Veiculo.Placa).GetAwaiter().GetResult();

            return new Servico()
            {
                Descricao = dto.Descricao,
                ValorServico = dto.ValorServico,
                Pecas = pecas,
                Status = Status.EmExecucao,
                Funcionario = funcionario,
                Veiculo = veiculo                
            };
        }
    }
}
