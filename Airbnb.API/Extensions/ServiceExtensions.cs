using Airbnb.BLL.Contracts;
using Airbnb.BLL.Services;
using Airbnb.DAL;
using Airbnb.DAL.Repositories;
using Airbnb.DomainModel.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }

    public static void ConfigureRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IRoomRepository, RoomRepository>();
        services.AddScoped<IReservationRepository, ReservationRepository>();
    }

    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IRoomService, RoomService>();
    }
}
