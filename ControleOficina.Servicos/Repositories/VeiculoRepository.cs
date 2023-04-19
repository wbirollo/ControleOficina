using ControleOficina.Servicos.Context;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleOficina.Servicos.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly ApplicationContext _context;

        public VeiculoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<Veiculo> Get(string placa)
        {
            return await _context.Veiculo.Include(c => c.Cliente).FirstOrDefaultAsync(c => c.Placa == placa);
        }
    }
}
