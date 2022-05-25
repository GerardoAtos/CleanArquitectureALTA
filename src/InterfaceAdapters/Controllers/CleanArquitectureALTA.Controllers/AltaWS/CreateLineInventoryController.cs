using Alta.Controllers.Filters;
using Alta.DTOs;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Alta.Controllers.AltaWS
{
    [HeaderValidationFilter]
    [Route("api/altaws")]
    [ApiController]
    public class CreateLineInventoryController : ControllerBase
    {
        private readonly ICreateLineInventoryInputPort _createLineInventoryInputPort;

        public CreateLineInventoryController(
            ICreateLineInventoryInputPort createLineInventoryInputPort
        ) => (_createLineInventoryInputPort) = (createLineInventoryInputPort);


        [HttpPost("CREATE_LINE_INVENTORY_IN_IFD")]
        public async Task<IActionResult> CreateLineInventoryInIFD(CreateLineInventoryDTO data)
        {
            await this._createLineInventoryInputPort.Handle(data);

            return Created(HttpContext.Request.Path, data);
        }
    }
}
