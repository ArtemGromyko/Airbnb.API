using Airbnb.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Airbnb.DAL.Configuration;

internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasData
        (
            new Review
            {
                Id = new Guid("865ce3fc-de0d-4372-901d-05e0ba2b8d02"),
                Raiting = 5,
                ReservationId = new Guid("f6736344-8a7e-43f4-9a1a-facf460b5f3f")
            }
        );
    }
}
