using Microsoft.Extensions.DependencyInjection;
using TodoTopado.Application.Interfaces;
using TodoTopado.Application.Services;
using TodoTopado.Infra;

namespace TodoTopado.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddDomainServiceDependency();
            services.AddInfraDependency();

            services.AddScoped<ITodoApplicationService, TodoApplicationService>();
        }
    }
}