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
    public class RequestInitiateRepository : IRequestInitiateRepository
    {
        public static string Name = "RequestInitiate";
        public IMongoCollection<RequestInitiateDTO> Collection { get; set; }
        private readonly IMongoContext _context;

        public RequestInitiateRepository(IMongoContext context) => (_context, Collection) = (context, context.GetCollectionByKey<RequestInitiateDTO>(Name));


        public async Task Insert(RequestInitiateDTO requestInitiateDTO)
        {
            await Collection.InsertOneAsync(requestInitiateDTO);
        }
    }
}
