using System.ComponentModel.DataAnnotations;

namespace AngularChatApp.Models
{
    public class User: BaseEntity
    {
        public Guid UserId { get; set; }

        public String? Name { get; set; }

        public String? Username { get; set; }

        [Required]
        public String? Password { get; set; }
    }
}
