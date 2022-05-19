using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces.Repositories
{
    public interface IHeartBeatConfirmRepository
    {
        public Task Insert(HeartBeatConfirm heartBeatConfirm);
    }
}
