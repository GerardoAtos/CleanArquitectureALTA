using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public class CreateLineInventoryRepository : ICreateLineInventoryRepository
    {
        public static string Name = "CreateLineInventory";
        public IMongoCollection<CreateLineInventory> Collection { get; set; }
        private readonly IMongoContext _context;
        
        public CreateLineInventoryRepository(IMongoContext context)
        {
            _context = context;
            Collection = context.GetCollectionByKey<CreateLineInventory>(Name);
        }

        public async Task Insert(CreateLineInventory createLineInventory)
        {
            await Collection.InsertOneAsync(createLineInventory);
        }
    }
}
