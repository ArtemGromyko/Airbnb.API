using Airbnb.DomainModel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Airbnb.DAL.Configuration;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Name).HasMaxLength(150);
        builder.Property(u => u.Email).HasMaxLength(150);

        builder.HasData(
            new User
            {
                Id = new Guid("85d2dad8-5ad5-4ad7-ab42-2a883cf0846a"),
                Name = "Tom",
                Email = "tom@email.com"
            },
            new User
            {
                Id = new Guid("bf62c2cd-aa17-47ea-b575-f8d769966fb9"),
                Name = "Bob",
                Email = "bob@email.com"
            }
        );
    }
}
