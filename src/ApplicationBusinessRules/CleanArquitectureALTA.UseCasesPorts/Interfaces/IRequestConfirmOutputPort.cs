using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IRequestConfirmOutputPort
    {
        Task Handle(RequestConfirmDTO _requestConfirmDTO);
    }
}
