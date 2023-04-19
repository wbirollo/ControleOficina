using ControleOficina.Domain.DTOs;
using ControleOficina.Domain.Entities;

namespace ControleOficina.Servicos.Mappers.Interfaces
{
    public interface IServicoMapper
    {
        public Servico ToNewEntity(ServicoDTO dto);
    }
}
