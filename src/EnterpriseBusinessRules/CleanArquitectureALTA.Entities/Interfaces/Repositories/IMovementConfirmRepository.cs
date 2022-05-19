using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces.Repositories
{
    public interface IMovementConfirmRepository
    {
        public Task Insert(MovementConfirm movementConfirm);
    }
}
