using Todo.Entities.TodoList;

namespace Todo.Web.Controllers;

public static class TodoController
{
    private static readonly TodoList TodoList = new();

    public static IResult GetAllTodos(HttpContext context)
    {
        return Results.Json(TodoList.GetAllTodos());
    }

    public static IResult CreateTodo(Records.Todo todo)
    {
        return Results.Json(TodoList.CreateNewTodo(todo));
    }
}