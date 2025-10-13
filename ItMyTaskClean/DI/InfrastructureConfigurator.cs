using ItMyTaskClean.Domain.Repositories;
using ItMyTaskClean.Infrastructure.Persistens;
using ItMyTaskClean.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ItMyTaskClean.Host.DI;

internal static class InfrastructureConfigurator
{
    public static void ConfigureInfrastructureServises(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SqlConnection");
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString,
                x => x.MigrationsHistoryTable("__EFMigrationsHistory"));
        });

        ConfigureRepositories(services, configuration);
    }
    public static void ConfigureRepositories(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IWorkRepository, WorkRepository>();
    }
}
