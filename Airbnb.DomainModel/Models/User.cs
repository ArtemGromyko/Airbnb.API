namespace Airbnb.DomainModel.Models;

public class User
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    public IEnumerable<Reservation>? Reservations { get; set; }
    public IEnumerable<Room>? Rooms { get; set; }
}
