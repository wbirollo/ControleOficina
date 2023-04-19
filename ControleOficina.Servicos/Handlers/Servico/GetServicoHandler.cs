using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Servicos.Responses;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico
{
    public class GetServicoHandler : IRequestHandler<GetServicoCommand, Response>
    {
        private readonly IServicoRepository _repository;

        public GetServicoHandler(IServicoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(GetServicoCommand request, CancellationToken cancellationToken)
        {
            var servico = await _repository.GetServico(request.Id);

            if (servico == null) return new Response { Status = 404, Message = "Não encontrado" };

            return new ResponseServico { Status = 200, Servico = servico };
        }
    }
}
