using ControleOficina.Domain.Entities;
using ControleOficina.Domain.Responses;

namespace ControleOficina.Servicos.Responses
{
    public class ResponseServico : Response
    {
        public Servico Servico { get; set; }
    }
}
