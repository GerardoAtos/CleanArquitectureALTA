using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public class RequestInitiateRepository : IRequestInitiateRepository
    {
        public static string Name = "RequestInitiate";
        public IMongoCollection<RequestInitiate> Collection { get; set; }
        private readonly IMongoContext _context;

        public RequestInitiateRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<RequestInitiate>(Name));


        public async Task Insert(RequestInitiate requestInitiate)
        {
            await Collection.InsertOneAsync(requestInitiate);
        }
    }
}
