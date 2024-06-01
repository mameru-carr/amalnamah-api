using Todo.Adapters.Database;

namespace Todo.Core.Entities.TodoList;

public interface TodoListDatabasePort
{
    public List<Core.Records.Todo> GetAllTodos();
    public Core.Records.Todo SaveNewTodo(Core.Records.Todo todo);
}

public class TodoList(TodoListDatabasePort entityFrameworKCoreDatabase)
{
    public List<Core.Records.Todo> GetAllTodos()
    {
        return entityFrameworKCoreDatabase.GetAllTodos();
    }

    public Core.Records.Todo CreateNewTodo(Core.Records.Todo todo)
    {
        return entityFrameworKCoreDatabase.SaveNewTodo(todo);
    }
}