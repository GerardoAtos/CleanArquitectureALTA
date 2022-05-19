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
    public class LoadErrorRepository : ILoadErrorRepository
    {

        public static string Name = "LoadError";
        public IMongoCollection<LoadErrorDTO> Collection { get; set; }
        private readonly IMongoContext _context;

        public LoadErrorRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<LoadErrorDTO>(Name));

        public async Task Insert(LoadErrorDTO loadErrordDTO)
        {
            await Collection.InsertOneAsync(loadErrordDTO);
        }
    }
}
