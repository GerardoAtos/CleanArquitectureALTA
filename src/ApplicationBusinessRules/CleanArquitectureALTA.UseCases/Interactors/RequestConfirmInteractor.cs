using Alta.DTOs;
using Alta.Mongo.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System.Threading.Tasks;

namespace Alta.UseCases.Interactors
{
    public class RequestConfirmInteractor : IRequestConfirmInputPort
    {
        private readonly ILoadDetailRepository _loadDetailRepository;
        private readonly ILoadErrorRepository _loadErrorRepository;
        public RequestConfirmInteractor(ILoadDetailRepository loadDetailRepository, ILoadErrorRepository loadErrorRepository) => 
            (_loadDetailRepository, _loadErrorRepository) = 
            (loadDetailRepository, loadErrorRepository);

        public async Task Handle(RequestConfirmDTO requestConfirmDTO)
        {
            if(requestConfirmDTO is LoadDetailedDTO) await _loadDetailRepository.Insert((LoadDetailedDTO)requestConfirmDTO);
            else if (requestConfirmDTO is LoadErrorDTO) await _loadErrorRepository.Insert((LoadErrorDTO)requestConfirmDTO);
        }
    }
}
