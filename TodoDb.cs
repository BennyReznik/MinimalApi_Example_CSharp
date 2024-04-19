using Microsoft.EntityFrameworkCore;

namespace MinimalApi_Example_CSharp
{
    public class TodoDb: DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
