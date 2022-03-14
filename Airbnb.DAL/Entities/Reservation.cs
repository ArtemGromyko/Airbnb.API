using System.ComponentModel.DataAnnotations;

namespace Airbnb.DAL.Entities;

public class Reservation
{
    public Guid Id { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }

    public Guid UserId { get; set; }
    public User? User { get; set; }

    public Guid RoomId { get; set; }
    public Room? Room { get; set; }

    public IEnumerable<Review>? Reviews { get; set; }
}
