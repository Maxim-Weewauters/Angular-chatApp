using System.ComponentModel.DataAnnotations;

namespace AngularChatApp.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        public String? name { get; set; }

        public String? username { get; set; }

        [Required]
        public String? Password { get; set; }
    }
}
