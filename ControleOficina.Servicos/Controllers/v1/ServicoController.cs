using ControleOficina.Domain.DTOs;
using ControleOficina.Domain.Responses;
using ControleOficina.Servicos.Handlers.Servico.Commands;
using ControleOficina.Servicos.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace ControleOficina.Servicos.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : BaseV1Controller<ServicoController>
    {
        private readonly IMediator _mediator;

        public ServicoController(ILogger<ServicoController> logger, IMediator mediator) : base(logger)
        {
            _mediator = mediator;
        }

        [HttpGet("qr-code")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseQrCode))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> ReadQrCode()
        {
            var response = await _mediator.Send(new GetQrCodeCommand());

            return StatusCode(response.Status, response);
        }

        [HttpPost("buscar-veiculo")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseVeiculo))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> GetVeiculoQrCode(byte[] qrcode)
        {
            var response = await _mediator.Send(new GetVeiculoQrCodeCommand { QrCode = qrcode });

            return StatusCode(response.Status, response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ResponseId))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> NewService([FromBody]ServicoDTO servico)
        {
            var response = await _mediator.Send(new NewServicoCommand { Servico = servico });

            if (response.Status == 201)
                return Created("", response);

            return StatusCode(response.Status, response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> UpdateStatusService(string id)
        {
            var response = await _mediator.Send(new UpdateStatusServicoCommand { Id = id });

            return StatusCode(response.Status, response);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ResponseServicos))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> GetServicos()
        {
            var response = await _mediator.Send(new GetServicosCommand());

            return StatusCode(response.Status, response);
        }

        [HttpGet("detalhes/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> GetServico(string id)
        {
            var response = await _mediator.Send(new GetServicoCommand { Id = id });

            return StatusCode(response.Status, response);
        }

        [HttpGet("veiculos-por-funcionario")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<IActionResult> GetVeiculosByFuncionario(string id)
        {
            var response = await _mediator.Send(new GetVeiculoByFuncionarioCommand { Id = id});

            return StatusCode(response.Status, response);
        }
    }
}
