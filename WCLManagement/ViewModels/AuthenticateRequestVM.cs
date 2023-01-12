using System.ComponentModel.DataAnnotations;

namespace WCLManagement.ViewModels
{
    public class AuthenticateRequestVM
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
