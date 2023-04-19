using ControleOficina.Domain.Responses;
using MediatR;

namespace ControleOficina.Cadastros.Handlers.Veiculo.Commands
{
    public class GetVeiculoCommand : IRequest<Response>
    {
        public string Placa { get; set; }
    }
}
