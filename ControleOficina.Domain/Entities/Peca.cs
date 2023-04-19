using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ControleOficina.Domain.Entities
{
    public class Peca : BaseEntity
    {
        [MaxLength(500)]
        public string Descricao { get; set; }

        public decimal ValorUnitario { get; set; }

        [MaxLength(50)]
        public string Codigo => NovoCodigo();

        [JsonIgnore]
        public virtual List<PecaServico> Pecas { get; set; }

        private string NovoCodigo()
        {
            return Guid.NewGuid().ToString("N").ToUpper()[..10];
        }
    }
}
