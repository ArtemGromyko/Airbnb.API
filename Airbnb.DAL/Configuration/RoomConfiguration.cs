using Airbnb.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Airbnb.DAL.Configuration;

internal class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.HasData
        (
            new Room
            {
                Id = new Guid("75518431-3035-4a5d-8f91-d8a6e8f8af47"),
                Address = "10019, West 53rd Street, New York",
                HasInternet = true,
                Price = 80,
                OwnerId = new Guid("bf62c2cd-aa17-47ea-b575-f8d769966fb9")
            },
            new Room
            {
                Id = new Guid("601ec7d3-b5c9-43c8-8adb-63fdc67bb1bd"),
                Address = "10014, Perry Street, New York",
                HasInternet = true,
                Price = 100,
                OwnerId = new Guid("bf62c2cd-aa17-47ea-b575-f8d769966fb9")
            }
        );
    }
}
