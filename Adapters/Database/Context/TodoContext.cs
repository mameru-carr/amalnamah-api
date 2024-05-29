using Microsoft.EntityFrameworkCore;

namespace Todo.Adapters.Database.Context;
public class TodoContext(DbContextOptions<TodoContext> options) : DbContext(options)
{
    public DbSet<Core.Records.Todo> Todos => Set<Core.Records.Todo>();
}