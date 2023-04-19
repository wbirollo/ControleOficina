using ControleOficina.Domain.Responses;
using Newtonsoft.Json;
using System.Drawing;

namespace ControleOficina.LeitorQrCode.Responses
{
    public class ResponseQrCode : Response
    {
        [JsonProperty("qrcode")]
        public byte[] QrCode { get; set; }
    }
}
