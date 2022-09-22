using WebApplication10.Models;

namespace WebApplication10.Entities
{
    public class UserPassword
    {
        public Guid Id { get; set; }
        public string Password { get; set; }
        public Guid UserId { get; set; }

        public User User{ get; set; }    

    }
}
