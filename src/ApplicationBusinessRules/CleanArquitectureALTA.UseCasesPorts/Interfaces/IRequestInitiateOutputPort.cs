using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IRequestInitiateOutputPort
    {
        Task Handle(RequestInitiateDTO requestInitiateDTO);
    }
}
