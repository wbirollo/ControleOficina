using ControleOficina.Domain.Enums;

namespace ControleOficina.Domain.DTOs
{
    public class ServicoDTO
    {
        public string Descricao { get; set; }
        public virtual List<PecaServicoDTO>? Pecas { get; set; }
        public decimal ValorServico { get; set; }
        public virtual FuncionarioDTO Funcionario { get; set; }

        public virtual VeiculoDTO Veiculo { get; set; }
    }
}
