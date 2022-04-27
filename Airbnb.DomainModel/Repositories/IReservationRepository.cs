using Airbnb.DomainModel.Models;

namespace Airbnb.DomainModel.Repositories
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetReservationListAsync();
        Task<Room> GetReservationAsync();
        Task CreateReservationAsync();
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(Reservation reservation);
    }
}
