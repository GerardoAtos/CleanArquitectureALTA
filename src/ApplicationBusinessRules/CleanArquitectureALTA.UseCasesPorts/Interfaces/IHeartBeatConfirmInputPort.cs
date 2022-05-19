using System.Threading.Tasks;
using Alta.DTOs;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IHeartBeatConfirmInputPort
    {
        Task Handle(HeartBeatConfirmDTO heartBeatConfirmDto);
    }
}