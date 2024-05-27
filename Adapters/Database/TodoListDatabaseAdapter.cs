using Microsoft.EntityFrameworkCore;
using Todo.Adapters.Database.Context;
using Todo.Entities.TodoList;

namespace Todo.Adapters.Database;

public class TodoListDatabaseAdapter : TodoListDatabasePort
{
    private readonly TodoSqliteContext _dbContext = new (
        new DbContextOptionsBuilder<TodoSqliteContext>()
            .UseSqlite("Data Source=Todo.db")
            .Options
        );
    public List<Records.Todo> GetAllTodos()
    {
        return _dbContext.Todos.ToList();
    }

    public Records.Todo SaveNewTodo(Records.Todo todo)
    {
        _dbContext.Add(todo);
        _dbContext.SaveChanges();
        return todo;
    }
}