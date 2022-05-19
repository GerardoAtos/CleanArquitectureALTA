using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces.Repositories
{
    public interface ILoadErrorRepository
    {
        public Task Insert(LoadError loadError);
    }
}
