using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Alta.Authentication
{
    public static class DependencyContainer 
    {
        public static IServiceCollection AddCookieAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication("CookieAuth")
              .AddCookie("CookieAuth", config =>
              {
                  config.Cookie.Name = "AltaWS.Cookie";
                  config.ExpireTimeSpan = TimeSpan.FromSeconds(120);
                  config.Events = new CookieAuthenticationEvents
                  {
                      OnRedirectToLogin = ctx =>
                      {
                          ctx.Response.StatusCode = 401;

                          return Task.CompletedTask;
                      },
                      OnRedirectToAccessDenied = ctx =>
                      {
                          ctx.Response.StatusCode = 401;

                          return Task.CompletedTask;
                      }
                  };
              });

            return services;
        }
    }
}
