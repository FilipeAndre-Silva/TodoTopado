using TodoTopado.Application.DTOs.Todo;
using TodoTopado.Domain.Entities;

namespace TodoTopado.Application.Interfaces
{
    public interface ITodoApplicationService
    {
        Task<CreateTodo> CreateTodoAsync(CreateTodo createTodo);
    }
}