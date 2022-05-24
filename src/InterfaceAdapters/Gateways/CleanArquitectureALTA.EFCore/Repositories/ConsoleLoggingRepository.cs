using Alta.Entities.Interfaces;
using Alta.Entities.POCOs;
using Alta.Utils;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace Alta.EFCore.Repositories
{
    public class ConsoleLoggingRepository : ILoggingRepository
    {

        private readonly IPublishEndpoint _publishEndpoint;

        public ConsoleLoggingRepository(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }
        public async Task<Log> InsertLogAsync(Log log)
        {
            Console.WriteLine(log.ToJson());
            await _publishEndpoint.Publish<Log>(log);

            return await Task.FromResult(log);
        }
    }
}
