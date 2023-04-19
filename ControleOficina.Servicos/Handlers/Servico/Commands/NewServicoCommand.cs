using ControleOficina.Domain.DTOs;
using ControleOficina.Domain.Responses;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico.Commands
{
    public class NewServicoCommand : IRequest<Response>
    {
        public ServicoDTO Servico { get; set; }
    }
}
