using AngularChatApp.Models;
using AngularChatApp.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AngularChatApp.Services
{
    public interface IUserService
    {
        Task<User> AddUser(User user);
        Task<List<User>> GetUsers();
    }

    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<User> AddUser(User user)
        {
            return await _userRepository.AddUser(user);
        }
    }
}
