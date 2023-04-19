namespace ControleOficina.Domain.DTOs
{
    public class VeiculoDTO
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Ano { get; set; }
        public string Placa { get; set; }
        public string? QrCode { get; set; }

        public virtual ClienteDTO? Cliente { get; set; }

        public virtual List<ServicoDTO>? Servicos { get; set; }
    }
}
