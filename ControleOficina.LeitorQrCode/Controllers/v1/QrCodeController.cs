using ControleOficina.Domain.Responses;
using ControleOficina.LeitorQrCode.Handlers.Veiculo.Commands;
using ControleOficina.LeitorQrCode.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ControleOficina.LeitorQrCode.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrCodeController : BaseV1Controller<QrCodeController>
    {
        private readonly IMediator _mediator;

        public QrCodeController(ILogger<QrCodeController> logger, IMediator mediator) : base(logger)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseQrCode))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> ReadQrCode()
        {
            var response = await _mediator.Send(new ReadCodeCommand());

            return StatusCode(response.Status, response);
        }
    }
}
