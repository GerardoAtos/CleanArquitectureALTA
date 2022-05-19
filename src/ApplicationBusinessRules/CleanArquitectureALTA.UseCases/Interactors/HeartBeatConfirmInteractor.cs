using System.Threading.Tasks;
using Alta.DTOs;
using Alta.Entities.Interfaces;
using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.UseCasesPorts.Interfaces;
using AutoMapper;

namespace Alta.UseCases.Interactors
{
    public class HeartBeatConfirmInteractor : IHeartBeatConfirmInputPort
    {
        private readonly ILoggingRepository _logger;
        private readonly IHeartBeatConfirmRepository _heartBeatConfirmRepository;
        private readonly IMapper _mapper;

        public HeartBeatConfirmInteractor(ILoggingRepository logger, IHeartBeatConfirmRepository heartBeatConfirmRepository, IMapper mapper)
            => (_logger, _heartBeatConfirmRepository, _mapper) = (logger, heartBeatConfirmRepository, mapper);

        public async Task Handle(HeartBeatConfirmDTO heartBeatConfirmDto)
        {
            await _logger.InsertLogAsync(new Log {Description = "hola"}); //TODO Definir el log

            //Map DTO to Entity and insert into Mongo
            await _heartBeatConfirmRepository.Insert(_mapper.Map<HeartBeatConfirm>(heartBeatConfirmDto));
        }
    }
}