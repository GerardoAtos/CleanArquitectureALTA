using Alta.EFCore.DataContext;
using Alta.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Alta.EFCore.Repositories
{
    public class UserLoginRepository : IUserLoginRepository
    {
        private readonly AltaContext _context;

        public UserLoginRepository(AltaContext context)
        {
            _context = context;
        }
        public async Task<bool> ExistsUserAsync(string username, string password)
        {
            return await _context.User.AnyAsync(x => x.UserName == username && x.Password == password && x.IsActive);
        }
    }
}
