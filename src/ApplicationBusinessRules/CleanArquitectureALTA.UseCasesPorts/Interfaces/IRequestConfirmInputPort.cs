using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IRequestConfirmInputPort
    {
        Task Handle(RequestConfirmDTO _requestConfirmDTO);       
    }
}
