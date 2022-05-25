using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IRequestInitiateInputPort
    {
        Task Handle(RequestInitiateDTO requestInitiateDTO);
    }
}
