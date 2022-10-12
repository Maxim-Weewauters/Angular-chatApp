using AngularChatApp.Configuration;
using AngularChatApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AngularChatApp.Data
{
    public class UserContext: DbContext
    {
        public DbSet<UserRegistration>? UserRegistrations { get; set; }

        private ConnectionStrings _connectionStrings;

        //empty constructor for migrations error
        public UserContext()
        {

        }

        public UserContext(DbContextOptions<UserContext> options, IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }
    }
}
