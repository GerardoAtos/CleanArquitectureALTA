using System;
using System.Threading.Tasks;
using Alta.DTOs;
using Alta.DTOs.HttpDTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.PrimeClient;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using AutoMapper;

namespace Alta.UseCases.Interactors
{
    public class RequestInitiateInteractor : IRequestInitiateInputPort
    {
        private readonly IRequestInitiateOutputPort _requestinitiateoutputport;
        private readonly ILoggingRepository _loggingRepository;
        private readonly IPrimeClient _primeClient;
        private readonly IAltaRepository _altaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly PrimeWsOptions _primeWsOptions;

        public RequestInitiateInteractor(IRequestInitiateOutputPort requestinitiateoutputport, ILoggingRepository loggingRepository, 
                                        IPrimeClient primeClient, IAltaRepository altaRepository, IMapper mapper, IUnitOfWork unitOfWork) =>
            (_loggingRepository, _requestinitiateoutputport, _primeClient, _altaRepository, _mapper, _unitOfWork) 
            = (loggingRepository, requestinitiateoutputport, primeClient, altaRepository, mapper, unitOfWork);

        public async Task Handle(RequestInitiateDTO requestInitiateDTO)
        {
            string uri = _primeWsOptions.Endpoints["RequestInitiate"]; 
            await _primeClient.Authenticate();
            await _loggingRepository.InsertLogAsync(new Log());
            TransactionResult result = await _primeClient.SendMessage(uri, requestInitiateDTO);
            await _altaRepository.InsertRequestInitiateAsync(_mapper.Map<RequestInitiate>(requestInitiateDTO));
            await _unitOfWork.SaveChanges();
            Console.WriteLine("result: " + result.ToJson());
            //TODO agregar la insercion del Json de RequestInitiateDTO
            await Task.CompletedTask;
        }
    }
}
