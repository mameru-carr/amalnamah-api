namespace Todo.Web.Routes.v1;

public static class ApiRoutes
{
    public static RouteGroupBuilder MapApiRoutesV1(this IEndpointRouteBuilder endpoints)
    {
        var apiGroup = endpoints.MapGroup("/v1/api");

        apiGroup.MapTodoApi();

        return apiGroup;
    }
}