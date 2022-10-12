using System.ComponentModel.DataAnnotations;

namespace AngularChatApp.Models
{
    public class UserRegistration
    {
        public Guid UserRegistrationId { get; set; }

        [Range(6, 16)]

        public String? name { get; set; }

        public String? username { get; set; }

        [Required]
        public String? Password { get; set; }
    }
}
