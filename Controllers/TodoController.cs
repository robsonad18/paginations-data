using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Paginacao.Data;
using Paginacao.Models;
using System.Data.SqlClient;

namespace Paginacao.Controllers
{
   [ApiController]
   [Route("v1/todos")]
    public class TodoController:ControllerBase
    {
       [HttpGet("load")]
       public async Task<IActionResult> LoadAsync([FromServices]AppDbContext context)
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

      [HttpGet]
       public async Task<IActionResult> GetAsync([FromServices]AppDbContext context)
       {
          var todos = await context.Todos.As
       }


    }
}