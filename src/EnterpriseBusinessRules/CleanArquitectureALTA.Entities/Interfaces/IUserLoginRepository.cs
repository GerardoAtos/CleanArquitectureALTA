using Alta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Entities.Interfaces
{
    public interface IUserLoginRepository
    {
        public Task<bool> ExistsUserAsync(string username, string password);
    }
}
