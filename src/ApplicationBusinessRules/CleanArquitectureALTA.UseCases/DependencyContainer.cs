using Alta.UseCases.Interactor;
using Alta.UseCasesPorts.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Alta.Profiles;
using Alta.UseCases.Interactors;

namespace Alta.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreateLineInventoryInputPort, CreateLineInventoryInteractor>();
            services.AddTransient<IHeartBeatInitiateInputPort, HeartBeatInitiateInteractor>();
            services.AddTransient<IMovementConfirmInputPort, MovementConfirmInteractor>();
            services.AddTransient<IRequestInitiateInputPort, RequestInitiateInteractor>();
            services.AddTransient<ILoginInputPort, LoginInteractor>();
            services.AddTransient<IRequestConfirmInputPort, RequestConfirmInteractor>();
            services.AddTransient<IHeartBeatConfirmInputPort, HeartBeatConfirmInteractor>();

            services.AddAutoMapper(typeof(ProfileBase), typeof(DependencyContainer));
            return services;
        }
    }
}
