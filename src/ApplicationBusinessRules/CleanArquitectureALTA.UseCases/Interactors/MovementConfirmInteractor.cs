using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Mongo.Repositories;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
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

        public MovementConfirmInteractor(IMovementConfirmOutputPort movementconfirmoutputport, ILoggingRepository logger,
            IPrimeClient primeClient, IOptions<PrimeWsOptions> options, IMovementConfirmRepository movementConfirmRepository) => 
            (_logger, _movementconfirmoutputport, _primeClient, _primeWsOptions, _movementConfirmRepository) = 
            (logger, movementconfirmoutputport, primeClient, options.Value, movementConfirmRepository);
       

        public async Task Handle(MovementConfirmDTO movmentConfirmDTO) 
        {            
            string uri = _primeWsOptions.Endpoints["MovementConfirm"];
            await _primeClient.Authenticate();
            await _logger.InsertLogAsync(new Log());
            await _primeClient.SendMessage(uri, movmentConfirmDTO);
            await _movementConfirmRepository.Insert(movmentConfirmDTO);
            
            //TODO agregar la insercion del Json de MovementConfirmDTO
            await Task.CompletedTask;
        }
    }
}