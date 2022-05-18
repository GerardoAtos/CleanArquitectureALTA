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
    public class HeartBeatConfirmRepository : IHeartBeatConfirmRepository
    {
        public static string Name = "HeartBeatConfirm";
        public IMongoCollection<HeartBeatConfirmDTO> Collection { get; set; }
        private readonly IMongoContext _context;

        public HeartBeatConfirmRepository(IMongoContext context)
        {
            _context = context;
            Collection = context.GetCollection<HeartBeatConfirmDTO>(Name);
        }

        public async Task Insert(HeartBeatConfirmDTO heartBeatConfirmDTO)
        {
            await Collection.InsertOneAsync(heartBeatConfirmDTO);
        }
    }
}
