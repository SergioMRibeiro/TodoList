using MeuTodo2.Data;
using MeuTodo2.Model;
using MeuTodo2.Model.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo2.Controllers
{
    [ApiController]
    [Route(template: "v1")]
    public class TodoController: ControllerBase
    {
        [HttpGet]
        [Route(template: "todos")]
        public async Task<IActionResult> GetAsync([FromServices]AppDbContext context)
        {
            List<MeuTodo> todos = await context.MeuTodos.AsNoTracking().ToListAsync();

            return Ok(todos);
        }

        [HttpGet]
        [Route(template: "todos/{id}")]
        public async Task<IActionResult> GetByIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {
            MeuTodo? todo = await context.MeuTodos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

            return todo == null ? NotFound() : Ok(todo);
        }

        [HttpPost(template: "todos")] // NOTE maneira alternativa de nomear a rota
        public async Task<IActionResult> PostAsync([FromServices] AppDbContext context, [FromBody] CreateTodoDTO model)
        {
            if (!ModelState.IsValid) // Caso não tenha nada no corpo do JSON recebido pela chamada, irá ocorrer um erro de badRequest
            {
                return BadRequest();
            }

            var todo = new MeuTodo
            {
                Date = DateTime.Now,
                Done = false,
                Title = model.Title,
                TargetEnd = model.TargetEnd,
                Description = model.Description
            };

            try
            {
                await context.MeuTodos.AddAsync(todo);
                await context.SaveChangesAsync();
                return Created(uri: $"v1/todos/{todo.Id}", todo);

            } catch {
                return StatusCode(500);
            }
        }

        [HttpPut]
        [Route (template: "todos/{id}")]
        public async Task<IActionResult> PutAsync([FromServices] AppDbContext context, [FromBody] ChangeTodoDTO model, [FromRoute] int id)
        {
            if (!ModelState.IsValid) // Caso não tenha nada no corpo do JSON recebido pela chamada, irá ocorrer um erro de badRequest
            {
                return BadRequest();
            }

            var todo = await context.MeuTodos.FirstOrDefaultAsync(x => x.Id == id);

            if (todo == null)
            {
                return NotFound();
            }


            try
            {

                todo.Title = model.Title;
                todo.Done = model.Done;
                todo.TargetEnd = model.TargetEnd;
                todo.Description = model.Description;

                context.MeuTodos.Update(todo);
                await context.SaveChangesAsync();
                return Ok(todo);

            }
            catch
            {
                return StatusCode(500);
            }
        }

        [HttpDelete (template:"todos/{id}")]
        public async Task<IActionResult> DeleteAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {
            var todo = await context.MeuTodos.FirstOrDefaultAsync (x => x.Id == id);


            if (todo == null)
            {
                return NotFound();
            }

            try
            {
                context.MeuTodos.Remove(todo);
                await context.SaveChangesAsync();

                return Ok("Item removido com sucesso!");
            } catch
            {
                return StatusCode(500);
            }
        }

    }
}
