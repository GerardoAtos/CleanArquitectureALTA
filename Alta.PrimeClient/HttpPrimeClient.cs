using Alta.DTOs.DtoAbstraction;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Alta.Utils;
using Polly;

namespace Alta.PrimeClient
{
    public class HttpPrimeClient : IPrimeClient
    {
        private readonly HttpClient _httpClient;
        private readonly PrimeWsOptions _primeWsOptions;

        public HttpPrimeClient(IOptions<PrimeWsOptions> options)
        {
            _httpClient = new HttpClient();
            _primeWsOptions = options.Value;
            _httpClient.BaseAddress = new Uri(_primeWsOptions.Url);
        }

        public async Task<TransactionResult> Authenticate()
        {
            var result = await _httpClient.PostAsync(_primeWsOptions.Endpoints["Authentication"], new StringContent(_primeWsOptions.Credentials.ToJson()));

            return await result.ToResult();
        }

        IAsyncPolicy circuitBreakerPolicy = Policy
            .Handle<Exception>().CircuitBreakerAsync(
                exceptionsAllowedBeforeBreaking: 3,
                onBreak: (exception, timespan) => { Console.WriteLine("Break"); },
                onReset: () => { Console.WriteLine("Reset"); },
                onHalfOpen: () => { Console.WriteLine("Half opened"); },
                durationOfBreak: TimeSpan.FromSeconds(5));

        public async Task<TransactionResult> SendMessage(string uri, DtoBase dto)
        {
            HttpContent content = new StringContent(JsonSerializer.Serialize(dto));
            var retryPolicy = Policy
                .Handle<HttpRequestException>().WaitAndRetryAsync(4, i => TimeSpan.FromSeconds(7), onRetry: (exeption, timespan, atempt) => { Console.WriteLine($"Reintentando"); }).WrapAsync(circuitBreakerPolicy);
            return await retryPolicy.ExecuteAsync(async () =>
            {
                var result = await _httpClient.PostAsync("https://pollytest.free.beeceptor.com/api/delaysixseconds", content);
                result.EnsureSuccessStatusCode();
                return await result.ToResult(dto);
            });

        }
    }
}