using System.ComponentModel.DataAnnotations;

namespace Airbnb.DAL.Entities;

public class Room
{
    public Guid Id { get; set; }
    [Required]
    [MaxLength(150)]
    public string? HomeType { get; set; }
    [Required]
    [MaxLength(150)]
    public string? Address { get; set; }
    [Required]
    public bool HasInternet { get; set; }
    [Required]
    public bool HatTv { get; set; }
    [Required]
    [Range(typeof(decimal), "0", "79228162514264337593543950335")]
    public decimal Price { get; set; }

    [Required]
    public Guid OwnerId { get; set; }
    public User? Owner { get; set; }

    public IEnumerable<Reservation>? Reservations { get; set; }
}
