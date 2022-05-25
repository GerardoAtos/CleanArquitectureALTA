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
    public class RequestInitiateController : ControllerBase
    {
        private readonly IRequestInitiateInputPort _requestInitiateInputPort;

        public RequestInitiateController(IRequestInitiateInputPort requestInitiateInputPort) =>
            (_requestInitiateInputPort) = (requestInitiateInputPort);


        [HttpPost("REQUEST_INITIATE")]
        public async Task<IActionResult> RequestInitiate(RequestInitiateDTO data)
        {
            await _requestInitiateInputPort.Handle(data);

            return Created(HttpContext.Request.Path, data);
        }
    }
}
