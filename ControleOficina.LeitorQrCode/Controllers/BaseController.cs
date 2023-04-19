using Microsoft.AspNetCore.Mvc;

namespace ControleOficina.LeitorQrCode.Controllers
{
    [Route("controle-qrcode/api/v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public abstract class BaseController<TController> : ControllerBase
    {
        private readonly ILogger<TController> _logger; 

        protected BaseController(ILogger<TController> logger)
        {
            _logger = logger;
        }
    }
}
