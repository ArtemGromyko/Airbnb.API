using Airbnb.DomainModel.Models;

namespace Airbnb.DomainModel.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUserListAsync();
        Task<User> GetUserAsync();
        Task CreateUserAsync();
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
    }
}