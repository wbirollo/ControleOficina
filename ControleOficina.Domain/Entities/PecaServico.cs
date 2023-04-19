using System.ComponentModel.DataAnnotations.Schema;

namespace ControleOficina.Domain.Entities
{
    public class PecaServico : BaseEntity
    {
        [ForeignKey("PecaId")]
        public Guid PecaId { get; set; }
        public virtual Peca Peca { get; set; }

        public long Quantidade { get; set; }

        [ForeignKey("ServicoId")]
        public Guid ServicoId { get; set; }

        public virtual Servico Servico { get; set; }
    }
}
