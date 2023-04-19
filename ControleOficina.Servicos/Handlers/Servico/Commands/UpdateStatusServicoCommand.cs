using ControleOficina.Domain.Responses;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico.Commands
{
    public class UpdateStatusServicoCommand : IRequest<Response>
    {
        public string Id { get; set; }
    }
}
