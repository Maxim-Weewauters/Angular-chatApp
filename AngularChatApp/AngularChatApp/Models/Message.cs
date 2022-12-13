using System.ComponentModel.DataAnnotations;

namespace AngularChatApp.Models
{
    public class Message: BaseEntity
    {
        public Guid MessageId { get; set; }

        public String? Text { get; set; }

        [Required]
        public Guid UserId { get; set; }

        public User user { get; set; }
    }
}
