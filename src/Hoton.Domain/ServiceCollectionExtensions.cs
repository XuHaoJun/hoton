using Hoton.Domain.Managers;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddManagers(this IServiceCollection services)
    {
        services.AddScoped<ProductManager>();
    }

    public static void AddRepositories(this IServiceCollection services) { }

    public static void AddServices(this IServiceCollection services) { }
}
