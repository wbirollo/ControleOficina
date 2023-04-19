using ControleOficina.Domain.Responses;

namespace ControleOficina.Servicos.Services.Interfaces
{
    public interface IServicoServices
    {
        public Task<Response> GetQrCode();
    }
}
