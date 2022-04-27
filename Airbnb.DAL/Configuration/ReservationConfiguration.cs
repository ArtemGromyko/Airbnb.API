using Airbnb.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Airbnb.DAL.Configuration;

internal class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasData
        (
            new Reservation
            {
                Id = new Guid("f6736344-8a7e-43f4-9a1a-facf460b5f3f"),
                StartDate = new DateTime(2022, 3, 20),
                EndDate = new DateTime(2022, 3, 27),
                RoomId = new Guid("75518431-3035-4a5d-8f91-d8a6e8f8af47"),
                UserId = new Guid("85d2dad8-5ad5-4ad7-ab42-2a883cf0846a")
            }
        );
    }
}
