using Airbnb.DomainModel.Models;
using Airbnb.DomainModel.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.DAL.Repositories;

public class ReservationRepository : RepositoryBase<Reservation>, IReservationRepository
{
    public ReservationRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

    public async Task<Reservation?> GetReservationByIdAsync(Guid id) =>
        await FindByCondition(r => r.Id.Equals(id)).SingleOrDefaultAsync();

    public async Task<List<Reservation>?> GetReservationListAsync() =>
        await FindAll().ToListAsync();

    public async Task CreateReservationAsync(Reservation reservation) =>
        await CreateAsync(reservation);

    public async Task UpdateReservationAsync(Reservation reservation) =>
        await UpdateAsync(reservation);

    public async Task DeleteReservationAsync(Reservation reservation) =>
        await DeleteAsync(reservation);
}
