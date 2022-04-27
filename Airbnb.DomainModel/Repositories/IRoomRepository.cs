using Airbnb.DomainModel.Models;

namespace Airbnb.DomainModel.Repositories
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetRoomListAsync();
        Task<Room> GetRoomAsync();
        Task CreateRoomAsync();
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(Room room);
    }
}
