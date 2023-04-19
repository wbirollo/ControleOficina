using ControleOficina.Domain.Responses;
using Newtonsoft.Json.Linq;
using ControleOficina.Servicos.Services.Interfaces;
using RestSharp;
using ControleOficina.Servicos.Responses;
using System.Drawing;
using ControleOficina.Servicos.Settings;
using Microsoft.Extensions.Options;

namespace ControleOficina.Servicos.Services
{
    public class ServicoServices : IServicoServices
    {
        private readonly ApplicationSettings _settings;

        public ServicoServices(IOptions<ApplicationSettings> settings)
        {
            _settings = settings.Value;
        }

        public async Task<Response> GetQrCode()
        {
            try
            {
                var client = new RestClient(_settings.Url);
                var request = new RestRequest($"api/QrCode", Method.Get);

                RestResponse response = await client.ExecuteAsync(request);

                var json = JObject.Parse(response.Content);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return new ResponseQrCode()
                    {
                        Status = 200,
                        QrCode = json.SelectToken("qrcode").ToObject<byte[]>()
                    };
                }
                else
                {
                    return new Response()
                    {
                        Message = json.SelectToken("message")?.ToString(),
                        Status = (int)response.StatusCode
                    };
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
