using System.ComponentModel.DataAnnotations;

namespace MeuTodo2.Model.DTO
{
    public class CreateTodoDTO
    {
        [Required]
        public string Title { get; set; }
    }
}
