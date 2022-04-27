using Airbnb.DAL.Configuration;
using Airbnb.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.DAL;

public class RepositoryContext : DbContext
{
    public DbSet<Reservation>? Reservations { get; set; }
    public DbSet<Review>? Reviews { get; set; }
    public DbSet<Room>? Rooms { get; set; }
    public DbSet<User>? Users { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new RoomConfiguration());
        modelBuilder.ApplyConfiguration(new ReservationConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewConfiguration());
    }
}
