using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControleOficina.LeitorQrCode.Controllers.v1
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
