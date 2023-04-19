using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QRCoder;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Imaging;

namespace ControleOficina.Domain.Entities
{
    public class Veiculo : BaseEntity
    {
        [MaxLength(50)]
        public string Marca { get; set; }

        [MaxLength(50)]
        public string Modelo { get; set; }

        [MaxLength(10)]
        public string Ano { get; set; }

        [MaxLength(10)]
        public string Placa { get; set; }

        [ForeignKey("ClienteId")]
        [MaxLength(100)]
        public Guid ClienteId { get; set; }

        [MaxLength(100)]
        public virtual Cliente Cliente { get; set; }

        [MaxLength(500)]
        [JsonIgnore]
        public virtual List<Servico>? Servicos { get; set; }

        [MaxLength(500)]
        public string? QrCode => GenerateQrCode();


        private string GenerateQrCode()
        {
            var obj = new JObject();
            obj.Add("placa", Placa);

            var json = JsonConvert.SerializeObject(obj);

            var arquivo = GetArquivoDir();

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(json, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save(arquivo, ImageFormat.Png);

            return arquivo;
        }

        private string GetArquivoDir()
        {
            var diretorio = Path.Combine("uploads", "qrCodes");

            if (!Directory.Exists(diretorio))
                Directory.CreateDirectory(diretorio);

            var name = $"{Modelo}_{Placa}.png";

            var arquivo = Path.Combine(diretorio, name);            

            return arquivo;
        }
    }
}
