using Alta.Entities.POCOs;
using MongoDB.Bson.Serialization;

namespace Alta.Mongo.Configurations
{
    public class MongoDesigner
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<Entity>(x => { 
            x.AutoMap(); 
            });
        }
    }
}
