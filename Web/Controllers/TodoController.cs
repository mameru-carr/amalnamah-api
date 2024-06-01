using Microsoft.EntityFrameworkCore;
using Todo.Adapters.Database;
using Todo.Adapters.Database.Context;
using Todo.Core.Entities.TodoList;

namespace Todo.Web.Controllers;

public static class TodoController
{
    private static readonly TodoContext _dbContext = new (
        new DbContextOptionsBuilder<TodoContext>()
            .UseSqlite("Data Source=Todo.db")
            .Options
        );
    
    private static readonly TodoList TodoList = new(new EntityFrameworKCoreDatabaseAdapter(_dbContext));

    public static IResult GetAllTodos(HttpContext context)
    {
        return Results.Json(TodoList.GetAllTodos());
    }

    public static IResult CreateTodo(Core.Records.Todo todo)
    {
        return Results.Json(TodoList.CreateNewTodo(todo));
    }
}