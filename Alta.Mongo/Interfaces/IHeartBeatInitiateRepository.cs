using Alta.DTOs;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public interface IHeartBeatInitiateRepository
    {
        public Task Insert(HeartBeatInitiateDTO heartBeatInitiateDTO);
    }
}
