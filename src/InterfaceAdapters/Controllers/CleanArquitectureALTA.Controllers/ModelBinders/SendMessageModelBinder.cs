using System;
using System.IO;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.DTOs.DtoAbstraction;
using Alta.Utils;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Alta.Controllers.ModelBinders
{
    public class SendMessageModelBinder : IModelBinder
    {
        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            string json = await new StreamReader(bindingContext.HttpContext.Request.Body).ReadToEndAsync();
            DtoBase dto = json.FromJson<DtoBase>();
            switch (dto)
            {
                case HeartBeatConfirmDTO:
                    Console.Out.WriteLine("Soy un HeartBeat");
                    break;
                case LoadDetailDTO:
                    Console.Out.WriteLine("Soy un LoadDetailed");
                    break;
                case LoadErrorDTO:
                    Console.Out.WriteLine("Soy un LoadError");
                    break;
            }
            bindingContext.Result = ModelBindingResult.Success(dto);
        }
    }
}