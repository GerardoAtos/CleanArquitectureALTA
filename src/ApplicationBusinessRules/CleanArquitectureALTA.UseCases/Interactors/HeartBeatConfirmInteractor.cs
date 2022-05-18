using System.Threading.Tasks;
using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using Alta.Utils;
using AutoMapper;

namespace Alta.UseCases.Interactors
{
    public class HeartBeatConfirmInteractor : IHeartBeatConfirmInputPort
    {
        private readonly IAltaRepository _altaRepository;
        private readonly ILoggingRepository _logging;
        private readonly IMapper _mapper;
        private readonly IHeartBeatConfirmRepository _heartBeatConfirmRepository;

        public HeartBeatConfirmInteractor(IAltaRepository altaRepository, IMapper mapper, ILoggingRepository logging, IHeartBeatConfirmRepository heartBeatConfirmRepository)
            => (_altaRepository, _mapper, _logging, _heartBeatConfirmRepository) = (altaRepository, mapper, logging, heartBeatConfirmRepository);

        public async Task Handle(HeartBeatConfirmDTO heartBeatConfirmDto)
        {
            
            await _altaRepository.SetHeartbeatConfirmAsync(_mapper.Map<HeartbeatInitiate>(heartBeatConfirmDto), heartBeatConfirmDto.ToJson());
            await _logging.InsertLogAsync(new Log {Description = "hola"}); //TODO Definir el log
            await _heartBeatConfirmRepository.Insert(heartBeatConfirmDto);
        }
    }
}