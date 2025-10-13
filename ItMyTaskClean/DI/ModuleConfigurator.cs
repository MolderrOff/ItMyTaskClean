using System.Reflection.Metadata.Ecma335;

namespace ItMyTaskClean.Host.DI;

public static class ModuleConfigurator
{
    public static IServiceCollection ConfigureModule(this IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureApplicationServices(configuration);
        services.ConfigureInfrastructureServises(configuration);

        return services;
    }
}
