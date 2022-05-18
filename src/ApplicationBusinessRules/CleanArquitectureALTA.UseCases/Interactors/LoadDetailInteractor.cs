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
    public class LoadDetailInteractor: ILoadDetailInputPort
    {
        private readonly IAltaRepository _altaRepository;
        private readonly ILoggingRepository _logging;
        private readonly IMapper _mapper;
        private readonly ILoadDetailRepository _loadDetailRepository;

        public LoadDetailInteractor(IAltaRepository altaRepository, ILoggingRepository logging, IMapper mapper, ILoadDetailRepository loadDetailRepository)
        {
            _altaRepository = altaRepository;
            _logging = logging;
            _mapper = mapper;
            _loadDetailRepository = loadDetailRepository;
        }

        public async Task Handle(LoadDetailedDTO dto)
        {
            await _logging.InsertLogAsync(new Log());
            await _altaRepository.SetLoadDetailAsync(_mapper.Map<LoadDetail>(dto), noted:true, dto.ToJson());
            await _loadDetailRepository.Insert(dto);
        }
    }
}