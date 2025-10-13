using System.Runtime.CompilerServices;
using ItMyTaskClean.Application.Services;
using ItMyTaskClean.Application.Services.Abstractions;

namespace ItMyTaskClean.Host.DI;

public static class ApplicationConfigurator
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IWorksService, WorkService>();
        return services;
    }
}
