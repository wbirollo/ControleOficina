using ControleOficina.Domain.Responses;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico.Commands
{
    public class GetVeiculoByFuncionarioCommand : IRequest<Response>
    {
        public string Id { get; set; }
    }
}
