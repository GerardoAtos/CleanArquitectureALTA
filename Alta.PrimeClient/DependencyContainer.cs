using Alta.EFCore.Repositories;
using Alta.Entities.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Timeout;
using System;
using System.Net.Http;

namespace Alta.PrimeClient
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPrimeClientServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ILoggingRepository, ConsoleLoggingRepository>();
            services.AddScoped<IPrimeClient, HttpPrimeClient>();
            AddClientWithPolicies(services);
            services.Configure<PrimeWsOptions>(configuration.GetSection(PrimeWsOptions.PrimeWs));
            return services;
        }

        private static void AddClientWithPolicies(IServiceCollection services)
        {
            Random jitterer = new Random();
            services.AddHttpClient<IPrimeClient, HttpPrimeClient>().AddTransientHttpErrorPolicy(builder =>
          builder.Or<TimeoutRejectedException>().WaitAndRetryAsync(
              5,
              retryAttempt => TimeSpan.FromSeconds(Math.Pow(2,retryAttempt)) + TimeSpan.FromMilliseconds(jitterer.Next(0,1000)),
              onRetry: (outcome, timeSpan, retryAttempt) =>
              {
                  //onretry to do
                  Console.WriteLine("Retry");
              }
            )).AddTransientHttpErrorPolicy(builder =>
          builder.Or<TimeoutRejectedException>().CircuitBreakerAsync(3,
          TimeSpan.FromSeconds(15),
          onBreak: (outcome, timeSpan) =>
          {
              //onbreak to do 
              Console.WriteLine("Break");
          },
          onReset: () =>
          {
              //onreset to do 
              Console.WriteLine("Reset");
          }
          )).AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(1));
        }
    }
}
