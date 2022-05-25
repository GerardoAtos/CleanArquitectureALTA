using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface ILoginInputPort
    {
        Task Handle(UserDTO user);
    }
}
