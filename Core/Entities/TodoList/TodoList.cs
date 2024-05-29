using Todo.Adapters.Database;

namespace Todo.Entities.TodoList;

public interface TodoListDatabasePort
{
    public List<Core.Records.Todo> GetAllTodos();
    public Core.Records.Todo SaveNewTodo(Core.Records.Todo todo);
}

public class TodoList(TodoListDatabaseAdapter todoListDatabase)
{
    public List<Core.Records.Todo> GetAllTodos()
    {
        return todoListDatabase.GetAllTodos();
    }

    public Core.Records.Todo CreateNewTodo(Core.Records.Todo todo)
    {
        return todoListDatabase.SaveNewTodo(todo);
    }
}