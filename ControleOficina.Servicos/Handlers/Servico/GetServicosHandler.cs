using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Servicos.Responses;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico
{
    public class GetServicosHandler : IRequestHandler<GetServicosCommand, Response>
    {
        private readonly IServicoRepository _repository;

        public GetServicosHandler(IServicoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(GetServicosCommand request, CancellationToken cancellationToken)
        {
            var servicos =  await _repository.GetServicos();

            if (servicos == null) return new Response { Status = 404, Message = "Nenhum serviço encontrado" };

            return new ResponseServicos { Status = 200, Servicos = servicos };
        }
    }
}
