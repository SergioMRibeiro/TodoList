namespace MeuTodo2.Model
{
    public class MeuTodo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Description { get; set; }
        public DateTime TargetEnd { get; set; }
    }
}
