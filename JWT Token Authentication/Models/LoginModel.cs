using System.ComponentModel.DataAnnotations;

namespace JWT_Token_Authentication.Models
{
    public class LoginModel
    {
        public string Username { get; set; } = "";

        public string Password { get; set; } = "";
    }
}
