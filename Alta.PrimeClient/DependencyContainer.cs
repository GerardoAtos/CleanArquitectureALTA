using Alta.EFCore.Repositories;
using Alta.Entities.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Alta.PrimeClient
{
    public static class DependencyContainer
    {
        public static IServiceCollection  AddPrimeClientServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ILoggingRepository, ConsoleLoggingRepository>();
            services.AddScoped<IPrimeClient, HttpPrimeClient>();

            services.Configure<PrimeWsOptions>(configuration.GetSection(PrimeWsOptions.PrimeWs));
            return services;
        }
    }
}
