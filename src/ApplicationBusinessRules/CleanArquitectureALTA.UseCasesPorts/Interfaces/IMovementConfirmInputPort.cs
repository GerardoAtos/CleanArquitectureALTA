using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IMovementConfirmInputPort
    {
        Task Handle(MovementConfirmDTO movementConfirmDTO);
    }
}
