using WebApplication1.DI;

namespace WebApplication1;

public static class ServiceExtensions
{
    public static IServiceCollection AddService(this IServiceCollection services)
    {
        services.AddScoped<IScopedInterface, ConcretClass>();
        services.AddTransient<ITransitentInterface, ConcretClass>();
        services.AddSingleton<ISingletonInterface, ConcretClass>();
        return services;
    }
}
