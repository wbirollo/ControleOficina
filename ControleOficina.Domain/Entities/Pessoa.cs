using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleOficina.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        [MaxLength(100)]
        public string Nome { get; set; }

        [MaxLength(20)]
        public string NumeroTelefone { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Cpf { get; set; }

        [MaxLength(200)]
        public string? Complemento { get; set; }

        [MaxLength(100)]
        public string Logradouro { get; set; }

        [MaxLength(10)]
        public string Numero { get; set; }

        [MaxLength(100)]
        public string Bairro { get; set; }

        [MaxLength(100)]
        public string Cidade { get; set; }

        [MaxLength(50)]
        public string Estado { get; set; }

        [MaxLength(50)]
        public string Pais { get; set; }
    }
}
