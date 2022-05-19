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
    public class LoadDetailRepository : ILoadDetailRepository
    {
        public static string Name = "LoadDetail";
        public IMongoCollection<LoadDetailedDTO> Collection { get; set; }
        private readonly IMongoContext _context;

        public LoadDetailRepository(IMongoContext context)
        {
            _context = context;
            Collection = context.GetCollectionByKey<LoadDetailedDTO>(Name);
        }

        public async Task Insert(LoadDetailedDTO loadDetailedDTO)
        {
            await Collection.InsertOneAsync(loadDetailedDTO);
        }
    }
}
