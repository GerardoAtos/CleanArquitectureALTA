using Alta.Controllers.Filters;
using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArquitectureALTA.Controllers.AltaWS
{
    [HeaderValidationFilter]
    [Route("api/altaws")]
    [ApiController]
    public class MovementConfirmController : ControllerBase
    {
        private readonly IMovementConfirmInputPort _movementConfirmInputPort;

        public MovementConfirmController(IMovementConfirmInputPort movementConfirmInputPort) =>
            (_movementConfirmInputPort) = (movementConfirmInputPort);


        [HttpPost("MOVEMENT_CONFIRM")]
        public async Task<IActionResult> MovementConfirm(MovementConfirmDTO data)
        {
            await _movementConfirmInputPort.Handle(data);

            return Created(HttpContext.Request.Path, data);
        }
    }
}
