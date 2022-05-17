using Alta.DTOs.DtoAbstraction;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo.Configurations
{
    public class MongoDesigner
    {
        public static void Configure()
        {
            BsonClassMap.RegisterClassMap<DtoBase>(x => { x.AutoMap(); });
            //var designs = typeof(DtoBase).Assembly.GetTypes()
            //.Where(types => !types.IsInterface && !types.IsAbstract && types.IsAssignableTo(typeof(DtoBase)));
            //foreach (var dtos in designs)
            //{
            //    BsonClassMap.RegisterClassMap()
            //}
        }
    }
}
