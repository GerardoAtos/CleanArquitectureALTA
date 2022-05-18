using Alta.Controllers.Filters;
using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArquitectureALTA.Controllers.AltaWS
{
    [HeaderValidationFilter]
    [Route("api/altaws")]
    [ApiController]
    public class  HeartBeatInititateController : ControllerBase
    {
        private readonly IHeartBeatInitiateInputPort _heartBeatInitiateInputPort;
        public HeartBeatInititateController(IHeartBeatInitiateInputPort heartBeatInitiateInputPort) => 
            (_heartBeatInitiateInputPort) = (heartBeatInitiateInputPort);

        [HttpPost("HEARTBEAT_INITIATE")]
        public async Task<IActionResult> HeartBeatInitiate(HeartBeatInitiateDTO data)
        {
            await _heartBeatInitiateInputPort.Handle(data);
            //TODO: ver que contestariamos dependiendo de si prime esta arriba o no
            return Ok();
        }
    }
}
