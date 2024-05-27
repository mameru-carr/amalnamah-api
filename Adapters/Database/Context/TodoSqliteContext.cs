using Microsoft.EntityFrameworkCore;

namespace Todo.Adapters.Database.Context;
public class TodoSqliteContext(DbContextOptions<TodoSqliteContext> options) : DbContext(options)
{
    public DbSet<Records.Todo> Todos => Set<Records.Todo>();
}