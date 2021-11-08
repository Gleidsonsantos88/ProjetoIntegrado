using IntegratedProject.Business.Customer.Interfaces;
using IntegratedProject.Data.Context;
using IntegratedProject.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace IntegratedProject.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IntegratedProjectDbContext>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}
