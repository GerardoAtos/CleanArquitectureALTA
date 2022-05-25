using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using AutoMapper;
using MassTransit;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class MovementConfirmInteractor : IMovementConfirmInputPort
    {
        private readonly IMovementConfirmOutputPort _movementconfirmoutputport;
        private readonly ILoggingRepository _logger;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;
        private readonly IMovementConfirmRepository _movementConfirmRepository;
        private readonly IMapper _mapper;
        private readonly IPublishEndpoint _publishEndpoint;

        public MovementConfirmInteractor(
            IMovementConfirmOutputPort movementconfirmoutputport,
            ILoggingRepository logger,
            IPrimeClient primeClient,
            IOptions<PrimeWsOptions> options,
            IMovementConfirmRepository movementConfirmRepository,
            IMapper mapper,
            IPublishEndpoint publishEndpoint
        ) =>
            (
                _logger,
                _movementconfirmoutputport,
                _primeClient,
                _primeWsOptions,
                _movementConfirmRepository,
                _mapper,
                _publishEndpoint
            ) = (
                logger,
                movementconfirmoutputport,
                primeClient,
                options.Value,
                movementConfirmRepository,
                mapper,
                publishEndpoint
            );

        public async Task Handle(MovementConfirmDTO movmentConfirmDTO)
        {
            string uri = _primeWsOptions.Endpoints["MovementConfirm"];
            await _primeClient.Authenticate();
            await _logger.InsertLogAsync(new Log { Description = "Movement confirm log." });
            await _primeClient.SendMessage(uri, movmentConfirmDTO);

            //Map DTO to Entity and insert into MongoDb
            await _movementConfirmRepository.Insert(
                _mapper.Map<MovementConfirm>(movmentConfirmDTO)
            );
            await _publishEndpoint.Publish<MovementConfirmDTO>(movmentConfirmDTO);

            await Task.CompletedTask;
        }
    }
}
