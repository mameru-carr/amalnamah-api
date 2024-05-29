using Todo.Adapters.Database.Context;
using Todo.Entities.TodoList;

namespace Todo.Adapters.Database;

public class TodoListDatabaseAdapter(TodoContext _dbContext) : TodoListDatabasePort
{
    public List<Core.Records.Todo> GetAllTodos()
    {
        return _dbContext.Todos.ToList();
    }

    public Core.Records.Todo SaveNewTodo(Core.Records.Todo todo)
    {
        _dbContext.Add(todo);
        _dbContext.SaveChanges();
        return todo;
    }
}