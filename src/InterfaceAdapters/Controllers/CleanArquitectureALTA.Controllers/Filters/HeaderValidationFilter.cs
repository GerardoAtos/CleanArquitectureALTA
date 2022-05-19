using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Alta.Controllers.Filters
{
    public class HeaderValidationFilter : ActionFilterAttribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            try
            {
                 GetHeaderValue("x-applicationaccess", context.HttpContext.Request.Headers);
                await next();
            }
            catch (ArgumentNullException ex)
            {
                context.Result = new BadRequestObjectResult("ERROR: Header x-applicationaccess is not provided"); 
            }
            
        }

        public static string GetHeaderValue(string key, IHeaderDictionary headers)
        {
            if (key == null) throw new ArgumentNullException($"{key}");

            StringValues receptacle = string.Empty;
            string value = string.Empty;

            headers.TryGetValue(key, out receptacle);

            if (!string.IsNullOrEmpty(receptacle)) value = receptacle.FirstOrDefault().ToString();

            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException($"{key}");

            return value;
        }
    }
}
