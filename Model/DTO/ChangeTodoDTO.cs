using System.ComponentModel.DataAnnotations;

namespace MeuTodo2.Model.DTO
{
    public class ChangeTodoDTO
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public bool Done { get; set; }
        public DateTime TargetEnd { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
