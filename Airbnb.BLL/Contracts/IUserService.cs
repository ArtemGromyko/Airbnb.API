using Airbnb.DomainModel.Models;

namespace Airbnb.BLL.Contracts;

public interface IUserService
{
    Task<List<User>?> GetUserListAsync();
    Task<User?> GetUserByIdAsync(Guid id);
}
