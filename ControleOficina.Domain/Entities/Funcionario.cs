using Newtonsoft.Json;

namespace ControleOficina.Domain.Entities
{
    public class Funcionario : Pessoa
    {
        [JsonIgnore]
        public virtual List<Servico>? Servicos { get; set; }
    }
}
