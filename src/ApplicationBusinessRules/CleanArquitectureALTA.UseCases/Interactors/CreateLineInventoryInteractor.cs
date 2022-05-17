using System;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.Extensions.Options;

namespace Alta.UseCases.Interactors
{
    public class CreateLineInventoryInteractor : ICreateLineInventoryInputPort
    {
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;
        private readonly IMongoService _mongoService;

       

        public CreateLineInventoryInteractor(ILoggingRepository loggingRepository, IPrimeClient primeClient, IOptions<PrimeWsOptions> options, IMongoService mongoService) => 
            (_loggingRepository, _primeClient, _primeWsOptions, _mongoService) = (loggingRepository, primeClient, options.Value, mongoService );

        public async Task Handle(CreateLineInventoryDTO createLineInventoryDTO)
        {
            string uri = _primeWsOptions.Endpoints["CreateLineInventoryInIFD"];
            await _primeClient.Authenticate();
            await _loggingRepository.InsertLogAsync(new Log());
            await _primeClient.SendMessage(uri, createLineInventoryDTO);
            await _mongoService.Insert(createLineInventoryDTO, "createLineInventoryIFD");
            await Task.CompletedTask;
        }
    }
}
