using Alta.DTOs;
using Alta.Presenters.Interfaces;
using Alta.UseCasesPorts.Interfaces;
using System.Threading.Tasks;

namespace Alta.Presenters.Presenters
{
    public class MovementConfirmPresenter : IMovementConfirmOutputPort, IPresenter<MovementConfirmDTO>
    {
        public MovementConfirmDTO Content { get; private set; }

        public async Task Handle(MovementConfirmDTO movementConfirmDTO)
        {
            Content = movementConfirmDTO;
            await Task.CompletedTask;
        }
    }
}
