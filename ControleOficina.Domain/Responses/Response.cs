using Newtonsoft.Json;

namespace ControleOficina.Domain.Responses
{
    public class Response
    {
        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonIgnore]
        public int Status { get; set; }
    }
}
