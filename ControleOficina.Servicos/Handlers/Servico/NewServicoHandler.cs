using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Mappers.Interfaces;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Servicos.Responses;
using ControleOficina.Servicos.Services.Interfaces;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico
{
    public class NewServicoHandler : IRequestHandler<NewServicoCommand, Response>
    {
        private readonly IServicoRepository _repository;
        private readonly IServicoServices _services;
        private readonly IServicoMapper _mapper;

        public NewServicoHandler(IServicoRepository repository, IServicoServices services, IServicoMapper mapper)
        {
            _repository = repository;
            _services = services;
            _mapper = mapper;
        }

        public async Task<Response> Handle(NewServicoCommand request, CancellationToken cancellationToken)
        {
            var servico = _mapper.ToNewEntity(request.Servico);

            if (servico == null) return new Response { Status = 400, Message = "Erro nos dados" };

            try
            {               
                var sucess = await _repository.Create(servico);

                if (!sucess)
                    throw new Exception();
            }
            catch (Exception)
            {
                return new Response { Status = 500, Message = "Erro ao criar serviço" };
            }

            return new ResponseId { Status = 201, Message = "Serviço criado", Id = servico.Id.ToString()};
        }
    }
}
