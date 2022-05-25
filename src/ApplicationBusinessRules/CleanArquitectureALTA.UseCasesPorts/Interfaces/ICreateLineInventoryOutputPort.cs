using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.UseCasesPorts.Interfaces
{
    public interface ICreateLineInventoryOutputPort
    {
        Task Handle(CreateLineInventoryDTO createLineInventoryDTO);
    }
}
