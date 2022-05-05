using Airbnb.DomainModel.Models;

namespace Airbnb.DomainModel.Repositories
{
    public interface IReservationRepository
    {
        Task<List<Reservation>?> GetReservationListAsync();
        Task<Reservation?> GetReservationByIdAsync(Guid id);
        Task CreateReservationAsync(Reservation reservation);
        Task UpdateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(Reservation reservation);
    }
}
