using Airbnb.DomainModel.Models;

namespace Airbnb.DomainModel.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>?> GetUserListAsync();
        Task<User?> GetUserByIdAsync(Guid id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
    }
}