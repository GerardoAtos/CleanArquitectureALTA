using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface ICreateLineInventoryInputPort
    {
        Task Handle(CreateLineInventoryDTO createLineInventoryDTO);
    }
}
