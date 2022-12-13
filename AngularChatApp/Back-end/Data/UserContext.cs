using AngularChatApp.Configuration;
using AngularChatApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AngularChatApp.Data
{
    public interface IUserContext
    {
        DbSet<Message>? Messages { get; set; }
        DbSet<User>? Users { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }

    public class UserContext : DbContext, IUserContext
    {
        public DbSet<User>? Users { get; set; }

        public DbSet<Message>? Messages { get; set; }

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
                Name = "maxim",
                Username = "maximeke",
                Password = "wachtwoord"
            });
            modelbuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                Name = "vincent",
                Username = "achterlijken",
                Password = "wachtwoord2"
            }); modelbuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                Name = "Wim",
                Username = "Wimpie",
                Password = "wimpie2000"
            });
            modelbuilder.Entity<User>().HasData(new User()
            {
                UserId = Guid.NewGuid(),
                Name = "maxim",
                Username = "maximeke",
                Password = "wachtwoord"
            });
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is BaseEntity && (
                    e.State == EntityState.Added || e.State == EntityState.Modified
                ));

            foreach (var entityEntry in entries)
            {
                ((BaseEntity)entityEntry.Entity).UpdatedDate = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseEntity)entityEntry.Entity).CreatedDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
