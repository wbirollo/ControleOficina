using ControleOficina.Cadastros.Handlers.Veiculo.Commands;
using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Servicos.Responses;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Veiculo
{
    public class GetVeiculoHandler : IRequestHandler<GetVeiculoCommand, Response>
    {
        private readonly IVeiculoRepository _repository;

        public GetVeiculoHandler(IVeiculoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(GetVeiculoCommand request, CancellationToken cancellationToken)
        {
            var veiculo = await _repository.Get(request.Placa);

            if (veiculo == null) 
                return new Response { Message = "Não encontrado", Status = 404 };

            return new ResponseVeiculo { Veiculo = veiculo, Status = 200 };
        }
    }
}
