using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.EFCore.Repositories
{
    public class ConsoleLoggingRepository : ILoggingRepository
    {
        public async Task<Log> InsertLogAsync(Log log)
        {
            Console.WriteLine(log.ToJson());
            return await Task.FromResult(log);
        }
    }
}
