using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface IMovementConfirmOutputPort
    {
        Task Handle(MovementConfirmDTO movementConfirmDTO);
    }
}
