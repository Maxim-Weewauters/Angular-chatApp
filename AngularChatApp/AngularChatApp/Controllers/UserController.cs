using AngularChatApp.Data;
using AngularChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularChatApp.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController
    {
        private UserContext _context;
        public UserController(UserContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch(Exception)
            {
                return new StatusCodeResult(500);
            }
           
        }
        [HttpPost]
        [Route("users")]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return new OkObjectResult(201);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }

        }
    }
}
