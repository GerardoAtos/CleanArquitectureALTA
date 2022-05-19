using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Utils;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Alta.Controllers.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ILoggingRepository loggingRepository)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await loggingRepository.InsertLogAsync(new Log() { Description = ex.Message, Resource = context.Request.Path });
                await HandleExceptionAsync(context, ex);
            }
        }

        public async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            
            await context.Response.WriteAsync(new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Message = "Error from: " + context.Request.Path
            }.ToJson());
        }
    }
}
