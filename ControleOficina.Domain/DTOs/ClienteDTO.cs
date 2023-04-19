using ControleOficina.Domain.Entities;

namespace ControleOficina.Domain.DTOs
{
    public class ClienteDTO : Pessoa
    {
        public virtual List<VeiculoDTO>? Veiculos { get; set; }
    }
}
