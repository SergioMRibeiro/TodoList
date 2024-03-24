using System.ComponentModel.DataAnnotations;

namespace MeuTodo2.Model.DTO
{
    public class CreateTodoDTO
    {
        [Required]
        public string Title { get; set; }
        public DateTime TargetEnd { get; set; }

        [Required]
        public string Description { get; set; }


    }
}
