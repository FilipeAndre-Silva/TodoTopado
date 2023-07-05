using TodoTopado.Domain.Entities;

namespace TodoTopado.Domain.Interfaces
{
    public interface ITodoService
    {
        void Add(Todo todo);
        Task<List<Todo>> GetAllByUseridAsync(int userId);
        Task<Todo> GetByIdAsync(int todoId);
        Task<Todo> UpdateAsync(int todoId, Todo todo);
        void DeleteAsync(int todoId);
    }
}