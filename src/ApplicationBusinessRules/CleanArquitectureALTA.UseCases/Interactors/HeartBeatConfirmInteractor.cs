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
        private readonly ILoggingRepository _logger;
        private readonly IHeartBeatConfirmRepository _heartBeatConfirmRepository;

        public HeartBeatConfirmInteractor(ILoggingRepository logger, IHeartBeatConfirmRepository heartBeatConfirmRepository)
            => (_logger, _heartBeatConfirmRepository) = (logger, heartBeatConfirmRepository);

        public async Task Handle(HeartBeatConfirmDTO heartBeatConfirmDto)
        {
            await _logger.InsertLogAsync(new Log {Description = "hola"}); //TODO Definir el log
            await _heartBeatConfirmRepository.Insert(heartBeatConfirmDto);
        }
    }
}