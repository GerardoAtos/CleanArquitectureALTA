using Alta.DTOs.DtoAbstraction;
using Alta.Mongo.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo
{
    public class MongoContext : IMongoContext
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        
        public MongoContext(IConfiguration configuration)
        {
            _client = new MongoClient(configuration.GetConnectionString("MongoConnectionString"));
            _database = _client.GetDatabase(configuration.GetConnectionString("DbName"));
        }

        public IMongoDatabase GetDatabase()
        {
            return _database;
        }
        public IMongoClient GetClient()
        {
            return _client;
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName) where T : DtoBase
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
