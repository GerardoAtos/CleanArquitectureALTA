using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public class HeartBeatInitiateRepository : IHeartBeatInitiateRepository
    {
        public static string Name = "HeartBeatInitiate";
        public IMongoCollection<HeartBeatInitiate> Collection { get; set; }
        private readonly IMongoContext _context;

        public HeartBeatInitiateRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<HeartBeatInitiate>(Name));

        public async Task Insert(HeartBeatInitiate heartBeatInitiate)
        {
            await Collection.InsertOneAsync(heartBeatInitiate);
        }
    }
}
