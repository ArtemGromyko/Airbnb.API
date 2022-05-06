using Airbnb.API.Extensions;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
var services = builder.Services;

// Add services to the container.
services.ConfigureSqlContext(configuration);
services.AddControllers();
services.ConfigureRepositories();
services.ConfigureServices();
services.AddEndpointsApiExplorer();
services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();
