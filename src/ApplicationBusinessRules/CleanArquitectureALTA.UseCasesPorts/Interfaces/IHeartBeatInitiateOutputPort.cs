using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IHeartBeatInitiateOutputPort
    {
        Task Handle(HeartBeatInitiateDTO heartBeatInitiateDTO);
    }
}
