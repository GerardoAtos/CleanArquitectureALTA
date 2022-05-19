using Alta.Entities.Interfaces.Repositories;
using Alta.Mongo.Configurations;
using Alta.Mongo.Interfaces;
using Alta.Mongo.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Alta.Mongo
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMongo(this IServiceCollection services, IConfiguration configuration)
        {
            MongoDesigner.Configure();
            services.Configure<MongoOptions>(configuration.GetSection(MongoOptions.MongoSettings));
            services.AddSingleton<IMongoContext, MongoContext>();
            services.AddScoped<ICreateLineInventoryRepository, CreateLineInventoryRepository>();
            services.AddScoped<IHeartBeatConfirmRepository, HeartBeatConfirmRepository>();
            services.AddScoped<IHeartBeatInitiateRepository, HeartBeatInitiateRepository>();
            services.AddScoped<ILoadDetailRepository, LoadDetailRepository>();
            services.AddScoped<ILoadErrorRepository, LoadErrorRepository>();
            services.AddScoped<IRequestInitiateRepository, RequestInitiateRepository>();
            services.AddScoped<IMovementConfirmRepository, MovementConfirmRepository>();
            
            return services;
        }
    }
}
