using Airbnb.DomainModel.Models;
using Airbnb.Models.RoomModels;
using Airbnb.Models.UserModels;
using AutoMapper;

namespace Airbnb.API.Services;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMapsForUser();
        CreateMapsForRooms();
    }

    private void CreateMapsForUser()
    {
        CreateMap<User, UserGetModel>().ReverseMap();
    }

    private void CreateMapsForRooms()
    {
        CreateMap<Room, RoomGetModel>().ReverseMap();
    }
}
