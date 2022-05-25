using Alta.DTOs;
using Alta.Presenters.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System.Threading.Tasks;

namespace Alta.Presenters.Presenters
{
    public class RequestInitiatePresenter : IRequestInitiateOutputPort, IPresenter<RequestInitiateDTO>
    {
        public RequestInitiateDTO Content { get; private set; }

        public async Task Handle(RequestInitiateDTO requestInitiateDTO)
        {
            Content = requestInitiateDTO;
            await Task.CompletedTask;
        }
    }
}
