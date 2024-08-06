using FluentValidation;
using JWT_Token_Authentication.Model;

namespace JWT_Token_Authentication.Validations
{
    public class RegisterValidator : AbstractValidator<RegisterModel>
    {
        public RegisterValidator()
        {
            RuleFor(obj => obj.Username)
                .NotEmpty().WithMessage("Username is required");
            RuleFor(obj => obj.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(8).WithMessage("Password must be atleast 8 characters long")
                .Matches(@"^(?=.* [A - Z])(?=.*\d)(?=.* [\W_]).+$").WithMessage("Password must have atleast 1 Capital Letter, 1 Number, 1 Special Character");
        }
    }
}
