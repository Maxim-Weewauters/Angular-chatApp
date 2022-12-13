using AngularChatApp.Data;
using AngularChatApp.Models;
using AngularChatApp.Repositories;
using AngularChatApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AngularChatApp.Controllers
{
    [ApiController]
    [Route("api")]
    public class UserController
    {

        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            try
            {
                return await _userService.GetUsers();
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
                await _userService.AddUser(user);
                return new OkObjectResult(201);
            }
            catch (Exception)
            {
                return new StatusCodeResult(500);
            }

        }
    }
}
