using System.Threading.Tasks;
using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Options;

namespace Alta.UseCases.Interactors
{
    public class HeartBeatInitiateInteractor : IHeartBeatInitiateInputPort
    {
        private readonly ILoggingRepository _loggingRepository;
        private readonly IAltaRepository _altaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPrimeClient _primeClient;
        private readonly PrimeWsOptions _primeWsOptions;
        private readonly IMapper _mapper;

        public HeartBeatInitiateInteractor(IHeartBeatInitiateOutputPort heartbeatOutputPort,
            ILoggingRepository loggingRepository, IAltaRepository altaRepository, IPrimeClient primeClient,
            IMapper mapper, IUnitOfWork unitOfWork, IOptions<PrimeWsOptions> options)
            =>
                (_, _loggingRepository, _altaRepository, _primeClient, _mapper, _unitOfWork, _primeWsOptions)
                = (heartbeatOutputPort, loggingRepository, altaRepository, primeClient, mapper, unitOfWork, options.Value);
        
        public async Task Handle(HeartBeatInitiateDTO heartBeatInitiateDTO)
        {
            string uri = _primeWsOptions.Endpoints["HeartBeatInitiate"];

            await _primeClient.Authenticate();
            await _primeClient.SendMessage(uri, heartBeatInitiateDTO);
            await _loggingRepository.InsertLogAsync(new Log());
            await _altaRepository.InsertHeartbeatInitiateAsync(_mapper.Map<HeartbeatInitiate>(heartBeatInitiateDTO));
            await _unitOfWork.SaveChanges();
            //TODO agregar la insercion del Json de HeartbeatInitiate
            await Task.CompletedTask;
        }
    }
}