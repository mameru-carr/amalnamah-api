using Todo.Adapters.Database;

namespace Todo.Entities.TodoList;

public interface TodoListDatabasePort
{
    public List<Records.Todo> GetAllTodos();
    public Records.Todo SaveNewTodo(Records.Todo todo);
}

public class TodoList
{
    private readonly TodoListDatabaseAdapter _todoListDatabase = new();
    
    public List<Records.Todo> GetAllTodos()
    {
        return _todoListDatabase.GetAllTodos();
    }

    public Records.Todo CreateNewTodo(Records.Todo todo)
    {
        return _todoListDatabase.SaveNewTodo(todo);
    }
}