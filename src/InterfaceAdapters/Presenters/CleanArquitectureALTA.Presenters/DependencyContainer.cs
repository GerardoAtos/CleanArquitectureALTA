
using Alta.Presenters.Presenters;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Alta.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreateLineInventoryOutputPort, CreateLineInventoryPresenter>();
            services.AddScoped<IHeartBeatInitiateOutputPort, HeartBeatInitiatePresenter>();
            services.AddScoped<IMovementConfirmOutputPort, MovementConfirmPresenter>();
            services.AddScoped<IRequestInitiateOutputPort, RequestInitiatePresenter>();
            services.AddScoped<ILoginOutputPort, LoginPresenter>();
            return services;
        }
    }
}
