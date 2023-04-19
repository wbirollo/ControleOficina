using ControleOficina.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleOficina.Domain.Entities
{
    public class Servico : BaseEntity
    {
        [MaxLength(500)]
        public string Descricao { get; set; }

        public virtual List<PecaServico>? Pecas { get; set; }

        public long QuantidadeItens => TotalItens();

        public decimal ValorServico { get; set; }

        public decimal ValorTotal => TotalServico();

        public DateTime? DataFinalizacao { get; set; }

        public Status Status { get; set; }

        [MaxLength(20)]
        public string CodigoServico => NovoCodigo();

        [ForeignKey("FuncionarioId")]
        public Guid FuncionarioId { get; set; }

        public virtual Funcionario Funcionario { get; set; }

        [ForeignKey("VeiculoId")]
        public Guid VeiculoId { get; set; }

        public virtual Veiculo Veiculo { get; set; }


        private string NovoCodigo()
        {
            return Guid.NewGuid().ToString("N").ToUpper()[..10];
        }

        private decimal TotalServico()
        {
            decimal result = 0;

            foreach (var item in Pecas)
                result += item.Quantidade * item.Peca.ValorUnitario;

            return result;
        }

        private long TotalItens()
        {
            long result = 0;

            foreach (var item in Pecas)
                result += item.Quantidade;

            return result;
        }
    }
}
