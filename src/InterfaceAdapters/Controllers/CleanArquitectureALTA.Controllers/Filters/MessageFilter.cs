using Alta.DTOs;
using Alta.DTOs.DtoAbstraction;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Alta.Controllers.Filters
{
    public class MessageFilter : ActionFilterAttribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            JsonElement json = JsonDocument.Parse(context.ActionArguments.FirstOrDefault().Value.ToString()).RootElement;
            bool Has(string prop) => json.TryGetProperty(prop, out _);

            var posibles = new[] {
                ("HEARTBEAT_CONFIRM", typeof(HeartBeatConfirmDTO)),
                ("LOAD_DETAIL", typeof(LoadDetailedDTO)),
                ("LOAD_ERROR", typeof(LoadErrorDTO))};
            
            DtoBase dto;
            foreach (var (property, dtoType) in posibles)
            {
                if (Has(property))
                {
                    dto = (DtoBase)JsonSerializer.Deserialize(json.ToString(), dtoType);
                    //dto = json.ToString().FromJson<DtoBase>(dtoType);
                    context.HttpContext.Items["data"] = dto;
                }
            }

            await next();

        }
    }
}
