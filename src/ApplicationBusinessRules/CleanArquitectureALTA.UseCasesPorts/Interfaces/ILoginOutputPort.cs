using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface ILoginOutputPort
    {
        Task Handle(UserDTO user, bool userExists);
    }
}
