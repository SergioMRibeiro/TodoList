using MeuTodo2.Model;
using Microsoft.EntityFrameworkCore;

namespace MeuTodo2.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<MeuTodo> MeuTodos {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
        }
    }
}
