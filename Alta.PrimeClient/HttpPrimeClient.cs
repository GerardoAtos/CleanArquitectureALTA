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

        public async Task<TransactionResult> SendMessage(string uri, DtoBase dto)
        {
            HttpContent content = new StringContent(JsonSerializer.Serialize(dto));

            //.WaitAndRetryAsync(3, i => TimeSpan.FromSeconds(15))
            var retryPolicy = Policy
                .Handle<HttpRequestException>().CircuitBreakerAsync(3, TimeSpan.FromSeconds(10),
                (ex, t) =>
                {
                    Console.WriteLine("Circuit broken.");
                }, 
                () =>
                {
                    Console.WriteLine("Circuit reset.");
                }); 

            return await retryPolicy.ExecuteAsync(async () =>
            {
                //https://pollytst.free.beeceptor.com/api/delaysixseconds
                //Console.WriteLine("reintentandooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo");
                var result = await _httpClient.PostAsync("https://pollytst.free.beeceptor.com/api/delaysixseconds", content);
                Console.WriteLine($"{retryPolicy.CircuitState}");
                //var result = await _httpClient.PostAsync(uri, content);
                result.EnsureSuccessStatusCode();

                return await result.ToResult(dto);
            });

        }
    }
}