using TodoTopado.Domain.Entities;

namespace TodoTopado.Infra.Interfaces
{
    public interface ITodoRepository
    {
        void Create(Todo todo);
    }
}