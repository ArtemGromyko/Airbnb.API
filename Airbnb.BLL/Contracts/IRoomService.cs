using Airbnb.DomainModel.Models;

namespace Airbnb.BLL.Contracts;

public interface IRoomService
{
    Task<List<Room>?> GetUserRoomsByIdAsync(Guid userId);
}
