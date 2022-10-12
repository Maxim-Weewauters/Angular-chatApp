using AngularChatApp.Configuration;
using AngularChatApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AngularChatApp.Data
{
    public class UserContext: DbContext
    {
        public DbSet<User>? Users { get; set; }

        private ConnectionStrings _connectionStrings;

        public UserContext(DbContextOptions<UserContext> options, IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionStrings = connectionStrings.Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_connectionStrings.SQL);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                name = "maxim",
                username = "maximeke",
                Password = "wachtwoord"
            });
            modelbuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                name = "vincent",
                username = "achterlijken",
                Password = "wachtwoord2"
            }); modelbuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                name = "Wim",
                username = "Wimpie",
                Password = "wimpie2000"
            });
        }
    }
}
