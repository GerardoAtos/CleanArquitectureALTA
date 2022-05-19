using Alta.DTOs;
using Alta.Mongo.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    internal class MovementConfirmRepository : IMovementConfirmRepository
    {
        public static string Name = "MovementConfirm";
        public IMongoCollection<MovementConfirmDTO> Collection { get; set; }
        private readonly IMongoContext _context;

        public MovementConfirmRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<MovementConfirmDTO>(Name));
        public async Task Insert(MovementConfirmDTO movementConfirmDTO)
        {
            await Collection.InsertOneAsync(movementConfirmDTO);
        }
    }
}
