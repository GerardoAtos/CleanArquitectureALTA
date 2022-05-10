﻿using Microsoft.Extensions.DependencyInjection;
using Alta.Presenters;
using Alta.UseCases;
using Alta.PrimeClient;
using Alta.EFCore;
using Microsoft.Extensions.Configuration;

namespace Alta.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAltaDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddUseCasesServices();
            services.AddPresenters();
            services.AddPrimeClientServices(configuration);
            services.AddEF(configuration);
            return services;
        }
    }
}
