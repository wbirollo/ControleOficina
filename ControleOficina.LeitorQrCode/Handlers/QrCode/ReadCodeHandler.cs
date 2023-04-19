using ControleOficina.Domain.Responses;
using ControleOficina.LeitorQrCode.Handlers.Veiculo.Commands;
using ControleOficina.LeitorQrCode.Responses;
using MediatR;
using System.Drawing;
using System.Drawing.Imaging;

namespace ControleOficina.LeitorQrCode.Handlers.Veiculo
{
    public class ReadCodeHandler : IRequestHandler<ReadCodeCommand, Response>
    {
        public async Task<Response> Handle(ReadCodeCommand request, CancellationToken cancellationToken)
        {
            var diretorio = Path.Combine("uploads", "qr-codes");

            var files = Directory.GetFiles(diretorio); 
            if (files.Length == 0)
            {
                return new Response { Status = 500 };
            }

            Random random = new Random();

            string arquivo = files[random.Next(files.Length)];

            Bitmap bitmap = new Bitmap(arquivo);

            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Png);
            byte[] byteArray = memoryStream.ToArray();

            if (byteArray == null)
                return new Response { Status = 404 };
            else
                return new ResponseQrCode { Status = 200, QrCode = byteArray };
        }
    }
}
