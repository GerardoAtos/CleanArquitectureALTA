﻿using Alta.Mongo.Configurations;
using Alta.Mongo.Interfaces;
using Alta.Mongo.Repositories;
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
