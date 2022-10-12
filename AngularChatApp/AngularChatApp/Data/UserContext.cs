using AngularChatApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularChatApp.Data
{
    public class UserContext: DbContext
    {
        public DbSet<UserRegistration> userRegistrations { get; set; }

        public UserContext()
        {

        }
    }
}
