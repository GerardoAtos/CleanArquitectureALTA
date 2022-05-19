using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.Mongo.Interfaces
{
    public interface IMongoService
    {
        Task Insert(CreateLineInventoryDTO createLineInventoryDTO, string v);
    }
}
