using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public class LoadDetailRepository : ILoadDetailRepository
    {
        public static string Name = "LoadDetail";
        public IMongoCollection<LoadDetail> Collection { get; set; }
        private readonly IMongoContext _context;

        public LoadDetailRepository(IMongoContext context)
        {
            _context = context;
            Collection = context.GetCollectionByKey<LoadDetail>(Name);
        }

        public async Task Insert(LoadDetail loadDetail)
        {
            await Collection.InsertOneAsync(loadDetail);
        }
    }
}
