using ControleOficina.Domain.Entities;
using ControleOficina.Domain.Responses;

namespace ControleOficina.Servicos.Responses
{
    public class ResponseServicos : Response
    {
        public List<Servico> Servicos { get; set; }
    }
}
