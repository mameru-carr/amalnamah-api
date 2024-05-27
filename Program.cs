using Todo.Adapters.Database.Context;
using Todo.Web.Routes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the Dependency Injection container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Database
builder.Services.AddSqlite<TodoSqliteContext>("Data Source=Todo.db");

builder.Services.AddLogging();
builder.Services.AddCors(options =>
{
    options.AddPolicy("FrontEnd", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

builder.Logging.AddJsonConsole();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.Logger.LogInformation("Running in Development Mode.");
    
    // Swagger Middleware
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middlewares
app.UseCors("FrontEnd");

app.MapGet("/check", () =>
    {
        app.Logger.LogInformation("Server started");
        var data = new
        {
            message = "The server is Alive and Kicking!"
        };
        var response = Results.Json(data);
        return response;
    })
    .WithName("Check")
    .WithOpenApi(generatedOperation =>
    {
        generatedOperation.Description = "Check if the API is working";
        return generatedOperation;
    });

app.MapApiRoutes();

app.Run();