using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog
{
    /// <summary>
    /// extension class
    /// </summary>
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            // add services for catalog module
            //services
            //    .AddApplicationServices()
            //    .AddInfrastructureServices(configuration);
            //    .AddApiServices(configuration);
            return services;
        }
    }
}
