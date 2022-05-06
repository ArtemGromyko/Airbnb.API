using Airbnb.BLL.Contracts;
using Airbnb.DomainModel.Models;
using Airbnb.DomainModel.Repositories;

namespace Airbnb.BLL.Services;

public class RoomService : IRoomService
{
    private readonly IRoomRepository _roomRepository;

    public RoomService(IRoomRepository roomRepository)
    {
        _roomRepository = roomRepository;
    }

    public async Task<List<Room>?> GetUserRoomsByIdAsync(Guid userId)
    {
        var roomDMList = await _roomRepository.GetUserRoomsByIdAsync(userId);

        return roomDMList;
    }
}
