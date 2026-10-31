using Microsoft.AspNetCore.Builder;
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

        // Phương thức mở rộng để cấu hình HTTP request pipeline cho module Catalog
        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            // Thêm các middleware hoặc cấu hình riêng cho module Catalog tại đây
            //app
            //    .UseApplicationServices()
            //    .UseInfrastructureServices()
            //    .UseApiServices();
            return app;// Trả về app để có thể chaining các phương thức khác
        }
    }
}
