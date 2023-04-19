using ControleOficina.Domain.Entities;

namespace ControleOficina.Servicos.Repositories.Interfaces
{
    public interface IVeiculoRepository
    {
        public Task<Veiculo> Get(string placa);
    }
}
