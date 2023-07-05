using AutoMapper;
using TodoTopado.Application.DTOs.Todo;
using TodoTopado.Application.Interfaces;
using TodoTopado.Domain.Entities;
using TodoTopado.Domain.Interfaces;

namespace TodoTopado.Application.Services
{
    public class TodoApplicationService : ITodoApplicationService
    {
        private readonly IMapper _mapper;
        private readonly ITodoService _todoService;
        public TodoApplicationService(IMapper mapper, ITodoService todoService)
        {
            _mapper = mapper;
            _todoService = todoService;
        }

        public async Task<CreateTodo> CreateTodoAsync(CreateTodo createTodo)
        {
            var todo = _mapper.Map<Todo>(createTodo);
            _todoService.Add(todo);
            return createTodo;
        }
    }
}