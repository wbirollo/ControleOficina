using ControleOficina.Domain.Entities;

namespace ControleOficina.Domain.DTOs
{
    public class FuncionarioDTO : Pessoa
    {
        public virtual List<ServicoDTO>? Servicos { get; set; }
    }
}

