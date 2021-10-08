using FatecItuApi.Business.Intefaces;
using FatecItuApi.Data.Context;
using FatecItuApi.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace FatecItuApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            return services;
        }
    }
}
