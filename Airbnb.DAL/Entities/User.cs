﻿using System.ComponentModel.DataAnnotations;

namespace Airbnb.DAL.Entities;

public class User
{
    public Guid Id { get; set; }
    [Required]
    [MaxLength(70)]
    public string? Name { get; set; }
    [Required]
    [MaxLength(70)]
    public string? Email { get; set; }
    [Required]
    [MaxLength(15)]
    public string? PhoneNumber { get; set; }

    public IEnumerable<Reservation>? Reservations { get; set; }
    public IEnumerable<Room>? Rooms { get; set; }
}
