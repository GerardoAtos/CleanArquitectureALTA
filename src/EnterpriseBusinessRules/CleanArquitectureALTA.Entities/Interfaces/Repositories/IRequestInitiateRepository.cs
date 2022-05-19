using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces.Repositories
{
    public interface IRequestInitiateRepository
    {
        public Task Insert(RequestInitiate requestInitiate);
    }
}
