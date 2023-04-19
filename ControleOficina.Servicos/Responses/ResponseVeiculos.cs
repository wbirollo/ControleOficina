using ControleOficina.Domain.Entities;
using ControleOficina.Domain.Responses;

namespace ControleOficina.Servicos.Responses
{
    public class ResponseVeiculos : Response
    {
        public List<Veiculo> Veiculos { get; set; }
    }
}
