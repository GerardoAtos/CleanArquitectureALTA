using System.Threading.Tasks;
using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Mongo.Repositories;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace Alta.UseCases.Interactors
{
    public class HeartBeatInitiateInteractor : IHeartBeatInitiateInputPort
    {
        private readonly ILoggingRepository _logger;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;
        private readonly IHeartBeatInitiateRepository _heartBeatInitiateRepository;

        public HeartBeatInitiateInteractor(ILoggingRepository logger, IPrimeClient primeClient, IOptions<PrimeWsOptions> options, IHeartBeatInitiateRepository heartBeatInitiateRepository) =>
                (_logger, _primeClient, _primeWsOptions, _heartBeatInitiateRepository) = 
                (logger, primeClient, options.Value, heartBeatInitiateRepository);
        
        public async Task Handle(HeartBeatInitiateDTO heartBeatInitiateDTO)
        {
            string uri = _primeWsOptions.Endpoints["HeartBeatInitiate"];

            await _primeClient.Authenticate();
            await _primeClient.SendMessage(uri, heartBeatInitiateDTO);
            await _logger.InsertLogAsync(new Log());

            //Insert into MongoDb
            await _heartBeatInitiateRepository.Insert(heartBeatInitiateDTO);
            await Task.CompletedTask;
        }
    }
}