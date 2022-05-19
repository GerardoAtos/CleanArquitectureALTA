using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public class HeartBeatConfirmRepository : IHeartBeatConfirmRepository
    {
        public static string Name = "HeartBeatConfirm";
        public IMongoCollection<HeartBeatConfirm> Collection { get; set; }
        private readonly IMongoContext _context;

        public HeartBeatConfirmRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<HeartBeatConfirm>(Name));

        public async Task Insert(HeartBeatConfirm heartBeatConfirm)
        {
            await Collection.InsertOneAsync(heartBeatConfirm);
        }
    }
}
