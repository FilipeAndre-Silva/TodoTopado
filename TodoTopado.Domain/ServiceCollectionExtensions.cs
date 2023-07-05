using Microsoft.Extensions.DependencyInjection;
using TodoTopado.Domain.Interfaces;
using TodoTopado.Domain.Services;

namespace TodoTopado.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDomainServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<ITodoService, TodoService>();
        }
    }
}