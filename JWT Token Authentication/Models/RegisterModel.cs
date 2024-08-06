using System.ComponentModel.DataAnnotations;

namespace JWT_Token_Authentication.Model
{
    public class RegisterModel
    {
        public string Username { get; set; } = "";

        public string Password { get; set; } = "";
    }
}
