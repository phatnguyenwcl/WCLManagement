using WCLManagement.Entities;

namespace WCLManagement.ViewModels
{
    public class AuthenticateResponseVM
    {
        public AuthenticateResponseVM(User user, string token)
        {
            ID = user.ID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Email = user.Email;
            Token = token;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
