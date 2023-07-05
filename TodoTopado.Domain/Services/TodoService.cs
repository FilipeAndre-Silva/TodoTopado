using TodoTopado.Domain.Entities;
using TodoTopado.Domain.Interfaces;
using TodoTopado.Infra.Interfaces;

namespace TodoTopado.Domain.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _repository;
        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public async void Add(Todo todo)
        {
            _repository.Create(todo);
        }

        public async Task<List<Todo>> GetAllByUseridAsync(int userId)
        {
            // buscar todos os todos pelo id do usuário no banco
            return new List<Todo>();
        }

        public async Task<Todo> GetByIdAsync(int todoId)
        {
            // buscar todos os todos pelo id no banco
            return new Todo("title", "description", DateTime.Now.AddDays(1));
        }

        public async Task<Todo> UpdateAsync(int todoId, Todo todo)
        {
            // Atualizar todo no banco de dados
            return new Todo("title", "description", DateTime.Now.AddDays(1));
        }

        public async void DeleteAsync(int todoId)
        {
            // Deletar todo do banco de dados
        }
    }
}