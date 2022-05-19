using Alta.Entities.POCOs;
using Alta.Mongo.Configurations;
using Alta.Mongo.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Alta.Mongo
{
    public class MongoContext : IMongoContext
    {
        private readonly IMongoClient _client;
        private readonly IMongoDatabase _database;
        private readonly MongoOptions _mongoOptions;

        public MongoContext(IConfiguration configuration, IOptions<MongoOptions> options)
        {
            _mongoOptions = options.Value;
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

        public IMongoCollection<T> GetCollection<T>(string collectionName) where T : Entity
        {
            return _database.GetCollection<T>(collectionName);
        }

        public IMongoCollection<T> GetCollectionByKey<T>(string key) where T : Entity
        {
            return _database.GetCollection<T>(_mongoOptions.Collections[key]);
        }
    }
}
