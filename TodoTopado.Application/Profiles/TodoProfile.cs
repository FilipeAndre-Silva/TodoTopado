using AutoMapper;
using TodoTopado.Application.DTOs.Todo;
using TodoTopado.Domain.Entities;

namespace TodoTopado.Application.Profiles
{
    public class TodoProfile : Profile
    {
        public TodoProfile()
        {
            CreateMap<Todo, CreateTodo>().ReverseMap();
        }
    }
}