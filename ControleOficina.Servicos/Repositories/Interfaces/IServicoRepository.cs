using ControleOficina.Domain.Entities;

namespace ControleOficina.Servicos.Repositories.Interfaces
{
    public interface IServicoRepository
    {
        public Task<List<Servico>> GetServicos();
        public Task<Servico> GetServico(string id);        
        public Task<bool> Create(Servico servico);
        public Task<bool> Update(Servico servico);
    }
}
