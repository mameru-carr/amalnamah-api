using Microsoft.OpenApi.Models;
using Todo.Web.Controllers;

namespace Todo.Web.Routes.v1;

public static class TodoRoutes
{
    public static RouteGroupBuilder MapTodoApi(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/todos");

        group.MapGet("/", TodoController.GetAllTodos).WithName("GetAllTodos").WithOpenApi();

        group.MapPost("/", TodoController.CreateTodo).WithName("CreateNewTodo").WithOpenApi(
            operation => new OpenApiOperation(operation)
            {
                OperationId = "CreateNewTodo",
                Summary = "Create a New Todo Record",
                Description = "Create a New Todo Record and return newly created record"
            });
        return group;
    }
}