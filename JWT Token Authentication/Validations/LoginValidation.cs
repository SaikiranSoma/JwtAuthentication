using FluentValidation;
using JWT_Token_Authentication.Models;

namespace JWT_Token_Authentication.Validations
{
    public class LoginValidation : AbstractValidator<LoginModel>
    {
        public LoginValidation()
        {
            RuleFor(login => login.Username)
                .NotEmpty().WithMessage("Username must not be empty");
            RuleFor(login => login.Password)
                .NotEmpty().WithMessage("Password must not be empty");
        }
    }
}
