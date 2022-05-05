using Airbnb.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

var services = builder.Services;
services.ConfigureSqlContext(configuration);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
