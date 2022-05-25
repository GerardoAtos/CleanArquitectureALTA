using System.Threading.Tasks;

namespace Alta.Entities.Interfaces
{
    public interface IUserLoginRepository
    {
        public Task<bool> ExistsUserAsync(string username, string password);
    }
}
