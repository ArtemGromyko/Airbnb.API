using Airbnb.BLL.Contracts;
using Airbnb.DomainModel.Models;
using Airbnb.DomainModel.Repositories;

namespace Airbnb.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserByIdAsync(Guid id)
        {
            var userDM = await _userRepository.GetUserByIdAsync(id);

            return userDM;
        }

        public async Task<List<User>?> GetUserListAsync()
        {
            var userDMList = await _userRepository.GetUserListAsync();

            return userDMList;
        }
    }
}
