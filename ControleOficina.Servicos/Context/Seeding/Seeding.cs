using ControleOficina.Cadastros.Context.SeedingService;
using ControleOficina.Servicos.Context.Seeding.Interfaces;

namespace ControleOficina.Servicos.Context.Seeding
{
    public class Seeding
    {
        private ISeedingCliente _seedingCliente;
        private ISeedingFuncionario _seedingFuncionario;
        private ISeedingPeca _seedingPeca;
        private ISeedingServico _seedingServico;

        public Seeding(ISeedingCliente seedingCliente, ISeedingFuncionario seedingFuncionario, ISeedingPeca seedingPeca, ISeedingServico seedingServico)
        {
            _seedingCliente = seedingCliente;
            _seedingFuncionario = seedingFuncionario;
            _seedingPeca = seedingPeca;
            _seedingServico = seedingServico;
        }

        public static void Seed(ApplicationContext dbcontext)
        {
            SeedingCliente.Seed(dbcontext);
            SeedingFuncionario.Seed(dbcontext);
            SeedingPeca.Seed(dbcontext);
            SeedingServico.Seed(dbcontext);
        }



    }
}
