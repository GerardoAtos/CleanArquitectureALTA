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
    public class HeartBeatInitiateRepository : IHeartBeatInitiateRepository
    {
        public static string Name = "HeartBeatInitiate";
        public IMongoCollection<HeartBeatInitiateDTO> Collection { get; set; }
        private readonly IMongoContext _context;

        public HeartBeatInitiateRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<HeartBeatInitiateDTO>(Name));

        public async Task Insert(HeartBeatInitiateDTO heartBeatInitiateDTO)
        {
            await Collection.InsertOneAsync(heartBeatInitiateDTO);
        }
    }
}
