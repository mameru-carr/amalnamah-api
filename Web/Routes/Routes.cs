namespace Todo.Web.Routes;

public static class ApiRoutes
{
    public static RouteGroupBuilder MapApiRoutes(this IEndpointRouteBuilder endpoints)
    {
        var apiGroup = endpoints.MapGroup("/api");

        apiGroup.MapTodoApi();

        return apiGroup;
    }
}