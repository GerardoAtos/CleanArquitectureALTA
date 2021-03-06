using Alta.DTOs;
using Alta.Mongo.Configurations;
using Alta.Mongo.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo.Repositories
{
    public class CreateLineInventoryRepository : ICreateLineInventoryRepository
    {
        public static string Name = "CreateLineInventory";
        public IMongoCollection<CreateLineInventoryDTO> Collection { get; set; }
        private readonly IMongoContext _context;
        
        public CreateLineInventoryRepository(IMongoContext context)
        {
            _context = context;
            Collection = context.GetCollectionByKey<CreateLineInventoryDTO>(Name);
        }

        public async Task Insert(CreateLineInventoryDTO createLineInventorydto)
        {
            await Collection.InsertOneAsync(createLineInventorydto);
        }
    }
}
