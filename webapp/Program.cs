var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/greeting", () => "Welcome to coca cola world!");

app.MapGet("/time", () => DateTime.Now.ToString());

app.MapGet("/random", () => Guid.NewGuid().ToString());

app.Run();
