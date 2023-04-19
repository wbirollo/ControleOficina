using ControleOficina.Domain.Enums;
using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Repositories.Interfaces;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico
{
    public class UpdateStatusServicoHandler : IRequestHandler<UpdateStatusServicoCommand, Response>
    {
        private readonly IServicoRepository _repository;

        public UpdateStatusServicoHandler(IServicoRepository repository)
        {
            _repository = repository;
        }

        public async Task<Response> Handle(UpdateStatusServicoCommand request, CancellationToken cancellationToken)
        {
            var servico = await _repository.GetServico(request.Id);

            if (servico == null) return new Response { Status = 404, Message = "Não encontrado" };

            servico.Status = Status.Concluido;
            servico.DataFinalizacao = DateTime.UtcNow;

            var sucess = await _repository.Update(servico);

            if (!sucess) return new Response { Status = 500, Message = "Erro ao atualizar" };

            return new Response { Status = 200, Message = "Atualização com sucesso" };
        }
    }
}
