using Alta.Entities.POCOs;
using MongoDB.Driver;

namespace Alta.Mongo.Interfaces
{
    public interface IMongoContext
    {
        public IMongoCollection<T> GetCollectionByKey<T>(string key) where T : Entity;
    }
}
