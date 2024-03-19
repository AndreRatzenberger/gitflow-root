var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Goodbye World!");

app.MapGet("/greeting", () => "Welcome to my web app!");

app.MapGet("/time", () => DateTime.Now.ToString());

app.MapGet("/random", () => Guid.NewGuid().ToString());

app.Run();
