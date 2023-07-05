using Microsoft.AspNetCore.Mvc;
using TodoTopado.Application.DTOs.Todo;
using TodoTopado.Application.Interfaces;

namespace TodoTopado.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoApplicationService _todoApplicationService;
    public TodoController(ITodoApplicationService todoApplicationService)
    {
        _todoApplicationService = todoApplicationService;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody]CreateTodo request)
    {
        if (request.IsInvalid()) return BadRequest(request.Erros());

        var result = await _todoApplicationService.CreateTodoAsync(request);
        return Ok(result);
    }
}