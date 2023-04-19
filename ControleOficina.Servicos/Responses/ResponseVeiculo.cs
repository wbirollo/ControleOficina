using ControleOficina.Domain.Entities;
using ControleOficina.Domain.Responses;
using Newtonsoft.Json;

namespace ControleOficina.Servicos.Responses
{
    public class ResponseVeiculo : Response
    {
        [JsonProperty("veiculo")]
        public Veiculo Veiculo { get; set; }
    }
}
