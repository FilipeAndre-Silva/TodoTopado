using Microsoft.EntityFrameworkCore;
using TodoTopado.Domain.Entities;

namespace TodoTopado.Infra.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options)
        { }

        public DbSet<Todo> Todos { get; set; }
    }
}