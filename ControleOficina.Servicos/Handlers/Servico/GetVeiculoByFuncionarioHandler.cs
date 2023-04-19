using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Servicos.Responses;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico
{
    public class GetVeiculoByFuncionarioHandler : IRequestHandler<GetVeiculoByFuncionarioCommand, Response>
    {
        private readonly IServicoRepository _repository;

        public GetVeiculoByFuncionarioHandler(IServicoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(GetVeiculoByFuncionarioCommand request, CancellationToken cancellationToken)
        {
            var servicos = await _repository.GetServicos();

            var veiculos = servicos.Where(c => c.Funcionario.Id.ToString() == request.Id).Select(c => c.Veiculo).ToList();

            if (!veiculos.Any()) return new Response { Status = 404 };

            return new ResponseVeiculos { Status = 200, Veiculos = veiculos };
        }
    }
}
