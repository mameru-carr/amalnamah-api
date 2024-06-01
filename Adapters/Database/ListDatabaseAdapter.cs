using Todo.Core.Entities.TodoList;

namespace Todo.Adapters.Database;

public class ListDatabaseAdapter: TodoListDatabasePort
{
    private List<Core.Records.Todo> _todos = new();

    public List<Core.Records.Todo> GetAllTodos()
    {
        return _todos;
    }

    public Core.Records.Todo SaveNewTodo(Core.Records.Todo todo)
    {
        _todos.Add(todo);
        return todo;
    }
    
}