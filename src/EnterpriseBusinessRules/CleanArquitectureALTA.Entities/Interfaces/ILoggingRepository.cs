using Alta.Entities.POCOs;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces
{
    public interface ILoggingRepository
    {
        Task<Log> InsertLogAsync(Log log);
    }
}
