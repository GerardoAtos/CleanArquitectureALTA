using System.Threading.Tasks;
using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using AutoMapper;
using MassTransit;
using Microsoft.Extensions.Options;

namespace Alta.UseCases.Interactors
{
    public class HeartBeatInitiateInteractor : IHeartBeatInitiateInputPort
    {
        private readonly ILoggingRepository _logger;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;
        private readonly IHeartBeatInitiateRepository _heartBeatInitiateRepository;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;

        public HeartBeatInitiateInteractor(
            ILoggingRepository logger,
            IPrimeClient primeClient,
            IOptions<PrimeWsOptions> options,
            IHeartBeatInitiateRepository heartBeatInitiateRepository,
            IMapper mapper,
            IPublishEndpoint publishEndpoint
        ) =>
            (
                _logger,
                _primeClient,
                _primeWsOptions,
                _heartBeatInitiateRepository,
                _mapper,
                _publishEndpoint
            ) = (
                logger,
                primeClient,
                options.Value,
                heartBeatInitiateRepository,
                mapper,
                publishEndpoint
            );

        public async Task Handle(HeartBeatInitiateDTO heartBeatInitiateDTO)
        {
            string uri = _primeWsOptions.Endpoints["HeartBeatInitiate"];

            await _primeClient.Authenticate();
            await _primeClient.SendMessage(uri, heartBeatInitiateDTO);
            await _logger.InsertLogAsync(new Log { Description = "Hearbeat Initiate log." });

            //Map DTO to Entity and insert into MongoDb
            await _heartBeatInitiateRepository.Insert(
                _mapper.Map<HeartBeatInitiate>(heartBeatInitiateDTO)
            );

            await _publishEndpoint.Publish<HeartBeatInitiateDTO>(heartBeatInitiateDTO);
            await Task.CompletedTask;
        }
    }
}
