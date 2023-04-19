using Microsoft.AspNetCore.Mvc;

namespace ControleOficina.Servicos.Controllers.v1
{
    [ApiVersion("1")]
    [ApiExplorerSettings(GroupName = "v1")]
    public abstract class BaseV1Controller<TController> : BaseController<TController>
    {
        protected BaseV1Controller(ILogger<TController> logger)
            : base(logger)
        {
        }
    }
}
