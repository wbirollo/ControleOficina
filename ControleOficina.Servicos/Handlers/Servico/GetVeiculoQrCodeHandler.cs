using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Repositories.Interfaces;
using ControleOficina.Servicos.Services.Interfaces;
using MediatR;
using System.Drawing.Imaging;
using ZXing;
using Newtonsoft.Json.Linq;
using ControleOficina.Cadastros.Handlers.Veiculo.Commands;
using System.Drawing;
using ZXing.Common;
using ZXing.QrCode;

namespace ControleOficina.Servicos.Handlers.Servico
{
    public class GetVeiculoQrCodeHandler : IRequestHandler<GetVeiculoQrCodeCommand, Response>
    {
        private readonly IServicoServices _services;
        private readonly IServicoRepository _repository;
        private readonly IMediator _mediator;

        public GetVeiculoQrCodeHandler(IServicoServices services, IServicoRepository repository, IMediator mediator)
        {
            _services = services;
            _repository = repository;
            _mediator = mediator;
        }

        public async Task<Response> Handle(GetVeiculoQrCodeCommand request, CancellationToken cancellationToken)
        {
            var memory = new MemoryStream(request.QrCode);
            var bitmap = new Bitmap(memory);

            BarcodeReader reader = new BarcodeReader();

            var resultado = reader.Decode(bitmap);

            var json = JObject.Parse(resultado.Text);

            var placa = json.SelectToken("placa")?.ToString();

            if (placa == null)
                return new Response { Status = 400, Message = "Erro no QrCode" };

            return await _mediator.Send(new GetVeiculoCommand { Placa = placa });
        }
    }
}
