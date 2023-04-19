using Microsoft.AspNetCore.Mvc;

namespace ControleOficina.Servicos.Controllers
{
    [Route("controle-oficina/api/v{version:apiVersion}/[controller]")]
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
