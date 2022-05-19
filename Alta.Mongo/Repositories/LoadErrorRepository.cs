using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public class LoadErrorRepository : ILoadErrorRepository
    {

        public static string Name = "LoadError";
        public IMongoCollection<LoadError> Collection { get; set; }
        private readonly IMongoContext _context;

        public LoadErrorRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<LoadError>(Name));

        public async Task Insert(LoadError loadError)
        {
            await Collection.InsertOneAsync(loadError);
        }
    }
}
