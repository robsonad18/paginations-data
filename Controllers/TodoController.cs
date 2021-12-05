using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using paginations_data.Data;
using paginations_data.Models;

namespace paginations_data.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController:ControllerBase
    {
        [HttpGet("load")]
        public async Task<IActionResult> loadAsync([FromServices]AppDbContext context)
        {
            for(var i = 0; i < 1348; i++)
            {
                var todo = new Todo 
                {
                    Id = i + 1,
                    Done = false,
                    CreateAt = System.DateTime.Now,
                    Title = $"Tarefa {i}"
                };
                await context.Todos.AddAsync(todo);
                await context.SaveChangesAsync();
            }
            return Ok();
        }
    }
}