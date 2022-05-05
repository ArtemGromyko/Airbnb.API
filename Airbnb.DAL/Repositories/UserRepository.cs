using Airbnb.DomainModel.Models;
using Airbnb.DomainModel.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Airbnb.DAL.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext) { }

    public async Task<User?> GetUserByIdAsync(Guid id) =>
        await FindByCondition(u => u.Id.Equals(id)).SingleOrDefaultAsync();

    public async Task<List<User>?> GetUserListAsync() =>
        await FindAll().ToListAsync();

    public async Task CreateUserAsync(User user) =>
        await UpdateAsync(user);

    public async Task UpdateUserAsync(User user) =>
        await DeleteAsync(user);

    public async Task DeleteUserAsync(User user) =>
        await DeleteAsync(user);
}
