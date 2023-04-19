namespace ControleOficina.Domain.DTOs
{
    public class PecaServicoDTO
    {
        public virtual PecaDTO Peca { get; set; }

        public long Quantidade { get; set; }

        public virtual ServicoDTO? Servico { get; set; }
    }
}
