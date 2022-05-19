using System.Threading.Tasks;
using Alta.DTOs;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface ILoadDetailInputPort
    {
        Task Handle(LoadDetailedDTO dto);
    }
}