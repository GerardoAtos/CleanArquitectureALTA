using Alta.EFCore.DataContext;
using Alta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.EFCore.Repositories
{
    public class SQLServerUnitOfWork : IUnitOfWork
    {
        private readonly AltaContext _context;

        public SQLServerUnitOfWork(AltaContext context) => (_context) = (context);

        public async Task<int> SaveChanges()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
