using Alta.Entities.Interfaces.Repositories;
using Alta.Entities.POCOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    internal class MovementConfirmRepository : IMovementConfirmRepository
    {
        public static string Name = "MovementConfirm";
        public IMongoCollection<MovementConfirm> Collection { get; set; }
        private readonly IMongoContext _context;

        public MovementConfirmRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<MovementConfirm>(Name));
        public async Task Insert(MovementConfirm movementConfirm)
        {
            await Collection.InsertOneAsync(movementConfirm);
        }
    }
}
