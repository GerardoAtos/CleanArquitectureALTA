using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces.Repositories
{
    public interface ICreateLineInventoryRepository
    {
        public Task Insert(CreateLineInventory createLineInventory);
    }
}
