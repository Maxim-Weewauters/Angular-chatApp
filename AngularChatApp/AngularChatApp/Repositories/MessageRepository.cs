using AngularChatApp.Data;

namespace AngularChatApp.Repositories
{
    public class MessageRepository { 
    
        //needs program.cs link
        private IUserContext _context;
        public MessageRepository(IUserContext context)
        {
            _context = context;
        }
    }
}
