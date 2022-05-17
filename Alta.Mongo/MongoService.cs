using Alta.DTOs;
using Alta.Mongo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo
{
    public class MongoService : IMongoService
    {
        private readonly IMongoContext _mongoContext;
        public Task Insert(CreateLineInventoryDTO createLineInventoryDTO, string collection)
        {
            _mongoContext.GetCollection(collection) <>;
        }
    }
}
