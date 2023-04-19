using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using QRCoder;
using System.Drawing.Imaging;

namespace ControleOficina.LeitorQrCode.Configurations
{
    public class Generator
    {
        public static void Generate()
        {
            var diretorio = Path.Combine("uploads", "qr-codes");

            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            var files = Directory.GetFiles(diretorio);

            if (!files.Any())
            {
                var placa1 = "FGA2S12";
                var placa2 = "HCC0V34";
                var placa3 = "FGH8J32";
                var placa4 = "EDS2X34";

                var placas = new List<string> { placa1, placa2, placa3, placa4 };

                foreach (var item in placas)
                    GenerateQrCode(item, diretorio);
            }            
        }

        private static string GenerateQrCode(string placa, string diretorio)
        {
            var obj = new JObject();
            obj.Add("placa", placa);

            var json = JsonConvert.SerializeObject(obj);

            var arquivo = GetArquivoDir(placa, diretorio);

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(json, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save(arquivo, ImageFormat.Png);

            return arquivo;
        }

        private static string GetArquivoDir(string placa, string diretorio)
        {           
            var name = $"{placa}.png";

            var arquivo = Path.Combine(diretorio, name);

            return arquivo;
        }

    }
}
