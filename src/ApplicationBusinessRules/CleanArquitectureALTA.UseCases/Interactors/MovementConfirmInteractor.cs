using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactor
{
    public class MovementConfirmInteractor : IMovementConfirmInputPort
    {
        private readonly IMovementConfirmOutputPort _movementconfirmoutputport;
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;

        public MovementConfirmInteractor(IMovementConfirmOutputPort movementconfirmoutputport, ILoggingRepository loggingRepository,
            IPrimeClient primeClient, IOptions<PrimeWsOptions> options) => 
            (_loggingRepository, _movementconfirmoutputport, _primeClient, _primeWsOptions) = 
            (loggingRepository, movementconfirmoutputport, primeClient, options.Value);
       

        public async Task Handle(MovementConfirmDTO movmentConfirmDTO) 
        {            
            string uri = _primeWsOptions.Endpoints["MovementConfirm"];
            await _primeClient.Authenticate();
            await _loggingRepository.InsertLogAsync(new Log());
            await _primeClient.SendMessage(uri, movmentConfirmDTO);
            //TODO agregar la insercion del Json de MovementConfirmDTO
            await Task.CompletedTask;
        }
    }
}