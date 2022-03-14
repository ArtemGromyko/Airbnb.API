using System.ComponentModel.DataAnnotations;

namespace Airbnb.DAL.Entities;

public class Review
{
    public Guid Id { get; set; }
    [Required]
    [Range(1, 5)]
    public int Raiting { get; set; }

    [Required]
    public Guid ReservationId { get; set; }
    public Reservation? Reservation { get; set; }
}
