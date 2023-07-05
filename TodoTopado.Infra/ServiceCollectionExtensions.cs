using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodoTopado.Infra.Data;
using TodoTopado.Infra.Interfaces;
using TodoTopado.Infra.Repositorys;

namespace TodoTopado.Infra
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfraDependency(this IServiceCollection services)
        {
            services.AddDbContext<TodoDbContext>(options => options.UseSqlite("Data Source=TodoInfra.db"));
            services.AddScoped<ITodoRepository, TodoRepository>();
        }
    }
}