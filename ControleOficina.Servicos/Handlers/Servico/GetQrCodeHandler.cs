using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Services.Interfaces;
using MediatR;

namespace ControleOficina.Servicos.Handlers.Servico
{
    public class GetQrCodeHandler : IRequestHandler<GetQrCodeCommand, Response>
    {
        private readonly IServicoServices _services;

        public GetQrCodeHandler(IServicoServices services)
        {
            _services = services;
        }

        public async Task<Response> Handle(GetQrCodeCommand request, CancellationToken cancellationToken)
        {
            return await _services.GetQrCode();           
        }
    }
}
