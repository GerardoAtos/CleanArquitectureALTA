using System.Threading.Tasks;
using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace Alta.UseCases.Interactors
{
    public class CreateLineInventoryInteractor : ICreateLineInventoryInputPort
    {
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;
        private readonly ICreateLineInventoryRepository _createLineInventoryRepository;
        private readonly IMapper _mapper;

        public CreateLineInventoryInteractor(ILoggingRepository loggingRepository, IPrimeClient primeClient, IOptions<PrimeWsOptions> options, ICreateLineInventoryRepository createLineInventoryRepository, IMapper mapper) => 
            (_loggingRepository, _primeClient, _primeWsOptions, _createLineInventoryRepository, _mapper) = (loggingRepository, primeClient, options.Value, createLineInventoryRepository, mapper);

        public async Task Handle(CreateLineInventoryDTO createLineInventoryDTO)
        {
            string uri = _primeWsOptions.Endpoints["CreateLineInventoryInIFD"];
            await _primeClient.Authenticate();

            await _loggingRepository.InsertLogAsync(new Log());

            await _primeClient.SendMessage(uri, createLineInventoryDTO);

            //Map DTO to Entity and insert into Mongo
            await _createLineInventoryRepository.Insert(_mapper.Map<CreateLineInventory>(createLineInventoryDTO));
            await Task.CompletedTask;
        }
    }
}
