namespace Airbnb.Models.RoomModels
{
    public class RoomGetModel
    {
        public Guid Id { get; set; }
        public string? Address { get; set; }
        public bool HasInternet { get; set; }
        public decimal Price { get; set; }
        public Guid OwnerId { get; set; }
    }
}
