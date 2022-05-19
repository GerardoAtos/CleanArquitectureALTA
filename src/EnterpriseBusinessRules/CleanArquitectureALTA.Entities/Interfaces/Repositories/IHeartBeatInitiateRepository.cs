using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces.Repositories
{
    public interface IHeartBeatInitiateRepository
    {
        public Task Insert(HeartBeatInitiate heartBeatInitiate);
    }
}
