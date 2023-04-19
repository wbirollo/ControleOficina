using ControleOficina.Domain.Responses;
using MediatR;
using System.Drawing;

namespace ControleOficina.Servicos.Handlers.Servico.Commands
{
    public class GetVeiculoQrCodeCommand : IRequest<Response>
    {
        public byte[] QrCode { get; set; }
    }
}
