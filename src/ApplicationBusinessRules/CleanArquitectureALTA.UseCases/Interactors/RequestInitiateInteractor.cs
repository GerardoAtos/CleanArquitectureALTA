using System;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Mongo.Repositories;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace Alta.UseCases.Interactors
{
    public class RequestInitiateInteractor : IRequestInitiateInputPort
    {
        private readonly IRequestInitiateOutputPort _requestInitiateOutputPort;
        private readonly ILoggingRepository _logger;
        private readonly IPrimeClient _primeClient;
        private readonly IRequestInitiateRepository _requestInitiateRepository;
        private readonly PrimeWsOptions _primeWsOptions;

        public RequestInitiateInteractor(IRequestInitiateOutputPort requestinitiateoutputport, ILoggingRepository logger, 
                                        IPrimeClient primeClient, IRequestInitiateRepository requestInitiateRepository, IOptions<PrimeWsOptions> primeWsOptions) =>
            (_logger, _requestInitiateOutputPort, _primeClient, _requestInitiateRepository, _primeWsOptions) 
            = (logger, requestinitiateoutputport, primeClient, requestInitiateRepository, primeWsOptions.Value);

        public async Task Handle(RequestInitiateDTO requestInitiateDTO)
        {
            string uri = _primeWsOptions.Endpoints["RequestInitiate"]; 
            await _primeClient.Authenticate();
            await _logger.InsertLogAsync(new Log());

            TransactionResult result = await _primeClient.SendMessage(uri, requestInitiateDTO);

            await _requestInitiateRepository.Insert(requestInitiateDTO);
            await Task.CompletedTask;
        }
    }
}
