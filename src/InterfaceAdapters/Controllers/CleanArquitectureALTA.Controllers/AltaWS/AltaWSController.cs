using System.Text.Json;
using System.Threading.Tasks;
using Alta.Controllers.Filters;
using Alta.DTOs;
using Alta.DTOs.DtoAbstraction;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Alta.Controllers.AltaWS
{
    [Route("api/[controller]")]
    [ApiController]
    public class AltaWSController : ControllerBase //ControllerBase is used because allow you to use multiple methods such as Ok(); instead of OkObject
    {

        private readonly IRequestConfirmInputPort _requestConfirmInputPort;
        private readonly IHeartBeatConfirmInputPort _heartBeatConfirmInputPort;

        public AltaWSController(IRequestConfirmInputPort requestConfirmInputPort, IHeartBeatConfirmInputPort heartBeatConfirmInputPort) => 
            (_requestConfirmInputPort, _heartBeatConfirmInputPort) = (requestConfirmInputPort, heartBeatConfirmInputPort);

        //We use async Task because when we have multiple request we might have troubles 
        // IActionResult Allow us to make the return with different status
        //When using IActionResult you won't be able to use a generic, usign ActionResult as class allow you to speciify a Generic in the return 

        [Authorize]
        [MessageFilter]
        [HttpPost("SEND_MESSAGE")]
        public async Task<IActionResult> SEND_MESSAGE(JsonElement json)
        {
            DtoBase dto = (DtoBase)HttpContext.Items["data"];
            if(dto is LoadDetailDTO || dto is LoadErrorDTO){
                await _requestConfirmInputPort.Handle((RequestConfirmDTO)dto);
            }
            else if (dto is HeartBeatConfirmDTO)
            {
                await _heartBeatConfirmInputPort.Handle((HeartBeatConfirmDTO)dto);
            }
            return Created(HttpContext.Request.Path, dto);
        }
        

    }
    
}
