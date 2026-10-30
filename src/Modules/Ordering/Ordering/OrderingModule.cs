using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            // add services for ordering module
            //services
            //    .AddApplicationServices()
            //    .AddInfrastructureServices(configuration);
            //    .AddApiServices(configuration);
            return services;
        }
    }
}
