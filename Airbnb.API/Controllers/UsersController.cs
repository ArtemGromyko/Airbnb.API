using Airbnb.BLL.Contracts;
using Airbnb.Models.RoomModels;
using Airbnb.Models.UserModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Airbnb.API.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IUserService _userService;
    private readonly IRoomService _roomService;

    public UsersController(IMapper mapper, IUserService userService, IRoomService roomService)
    {
        _mapper = mapper;
        _userService = userService;
        _roomService = roomService;
    }

    [HttpGet]
    public async Task<IActionResult> GetUserListAsync()
    {
        var userDMList = await _userService.GetUserListAsync();

        if (userDMList == null)
        {
            return NoContent();
        }

        return Ok(_mapper.Map<List<UserGetModel>>(userDMList));
    }

    [HttpGet("id")]
    public async Task<IActionResult> GetUserByIdAsync(Guid id)
    {
        var userDM = await _userService.GetUserByIdAsync(id);

        if (userDM == null)
        {
            return NotFound();
        }

        return Ok(_mapper.Map<UserGetModel>(userDM));
    }

    [HttpGet("id/rooms")]
    public async Task<IActionResult> GetUserRoomsByIdAsync(Guid id)
    {
        var userDM = await _userService.GetUserByIdAsync(id);

        if (userDM == null)
        {
            return NotFound();
        }

        var roomDMList = await _roomService.GetUserRoomsByIdAsync(id);

        if (roomDMList == null)
        {
            return NoContent();
        }

        return Ok(_mapper.Map<List<RoomGetModel>>(roomDMList));
    }
}
