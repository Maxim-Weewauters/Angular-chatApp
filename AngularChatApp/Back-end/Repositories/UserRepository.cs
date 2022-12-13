using AngularChatApp.Data;
using AngularChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularChatApp.Repositories
{
    public interface IUserRepository
    {
        Task<User> AddUser(User user);
        Task<List<User>> GetUsers();
    }

    public class UserRepository : IUserRepository
    {
        private IUserContext _context;
        public UserRepository(IUserContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> AddUser(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
