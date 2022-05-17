using Alta.Mongo.Configurations;
using Alta.Mongo.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alta.Mongo
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMongo(this IServiceCollection services, IConfiguration configuration)
        {
            MongoDesigner.Configure();
            services.AddSingleton<IMongoContext, MongoContext>();
            return services;
        }
    }
}
