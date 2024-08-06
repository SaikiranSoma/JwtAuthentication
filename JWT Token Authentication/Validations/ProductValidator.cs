using FluentValidation;
using JWT_Token_Authentication.Models;

namespace JWT_Token_Authentication.Validations
{
    public class ProductValidator : AbstractValidator<Product> 
    {
        public ProductValidator() 
        {
            RuleFor(product => product.Name)
                .NotEmpty().WithMessage("Product Name must not be Empty");
            RuleFor(product => product.Price)
                .NotEmpty().WithMessage("Product Price must not be Empty")
                .GreaterThanOrEqualTo(0).WithMessage("Product Price must be greater than or equal to zero");
        }
    }
}
