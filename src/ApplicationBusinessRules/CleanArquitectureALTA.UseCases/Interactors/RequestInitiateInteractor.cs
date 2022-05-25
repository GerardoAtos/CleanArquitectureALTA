using System.Threading.Tasks;
using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
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
    public class RequestInitiateInteractor : IRequestInitiateInputPort
    {
        private readonly IRequestInitiateOutputPort _requestInitiateOutputPort;
        private readonly ILoggingRepository _logger;
        private readonly IPrimeClient _primeClient;
        private readonly IRequestInitiateRepository _requestInitiateRepository;
        private readonly PrimeWsOptions _primeWsOptions;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;

        public RequestInitiateInteractor(
            IRequestInitiateOutputPort requestinitiateoutputport,
            ILoggingRepository logger,
            IPrimeClient primeClient,
            IRequestInitiateRepository requestInitiateRepository,
            IOptions<PrimeWsOptions> primeWsOptions,
            IMapper mapper,
            IPublishEndpoint publishEndpoint
        ) =>
            (
                _logger,
                _requestInitiateOutputPort,
                _primeClient,
                _requestInitiateRepository,
                _primeWsOptions,
                _mapper,
                _publishEndpoint
            ) = (
                logger,
                requestinitiateoutputport,
                primeClient,
                requestInitiateRepository,
                primeWsOptions.Value,
                mapper,
                publishEndpoint
            );

        public async Task Handle(RequestInitiateDTO requestInitiateDTO)
        {
            string uri = _primeWsOptions.Endpoints["RequestInitiate"];
            await _primeClient.Authenticate();
            await _logger.InsertLogAsync(new Log { Description = "Request initiate log." });

            TransactionResult result = await _primeClient.SendMessage(uri, requestInitiateDTO);

            //Map DTO to Entity and insert into MongoDb
            await _requestInitiateRepository.Insert(
                _mapper.Map<RequestInitiate>(requestInitiateDTO)
            );
            await _publishEndpoint.Publish<RequestInitiateDTO>(requestInitiateDTO);
            await Task.CompletedTask;
        }
    }
}
