using ControleOficina.Domain.Entities;
using ControleOficina.Servicos.Context;
using ControleOficina.Servicos.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleOficina.Servicos.Repositories
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly ApplicationContext _context;

        public ServicoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Servico>> GetServicos()
        {
            return await _context.Servico.Include(c => c.Funcionario)
                .Include(c => c.Veiculo)
                .Include(c => c.Pecas)
                .ThenInclude(c => c.Peca)
                .ToListAsync();
        }

        public async Task<Servico> GetServico(string id)
        {
            return await _context.Servico.Include(c => c.Funcionario).Include(c => c.Veiculo)
                .Include(c => c.Pecas).ThenInclude(c => c.Peca)
                .FirstOrDefaultAsync(c => c.Id.ToString() == id);
        }

        public async Task<bool> Create(Servico servico)
        {
            try
            {
                servico.DataCriacao = DateTime.UtcNow;

                await _context.Servico.AddAsync(servico);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Update(Servico servico)
        {
            try
            {
                _context.Servico.Update(servico);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
