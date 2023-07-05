using TodoTopado.Domain.Entities;
using TodoTopado.Infra.Data;
using TodoTopado.Infra.Interfaces;

namespace TodoTopado.Infra.Repositorys
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoDbContext _context;
        public TodoRepository(TodoDbContext context)
        {
            _context = context;
        }

        public async void Create(Todo todo)
        {
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
        }
    }
}