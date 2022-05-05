﻿using Airbnb.DomainModel.Models;

namespace Airbnb.DomainModel.Repositories
{
    public interface IRoomRepository
    {
        Task<List<Room>?> GetRoomListAsync();
        Task<Room?> GetRoomByIdAsync(Guid id);
        Task CreateRoomAsync(Room room);
        Task UpdateRoomAsync(Room room);
        Task DeleteRoomAsync(Room room);
    }
}
