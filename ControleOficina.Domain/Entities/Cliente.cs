namespace ControleOficina.Domain.Entities
{
    public class Cliente : Pessoa
    {
        public virtual List<Veiculo> Veiculos { get; set; }

    }
}
