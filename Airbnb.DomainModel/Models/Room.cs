namespace Airbnb.DomainModel.Models;

public class Room
{
    public Guid Id { get; set; }
    public string? Address { get; set; }
    public bool HasInternet { get; set; }
    public decimal Price { get; set; }

    public Guid OwnerId { get; set; }
    public User? Owner { get; set; }

    public IEnumerable<Reservation>? Reservations { get; set; }
}
