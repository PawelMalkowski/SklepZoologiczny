using FluentValidation;
using SklepZoologiczny.IServices.Requests;

namespace SklepZoologiczny.Api.Validation
{
    public class CreateUserValidator: AbstractValidator<CreateUser>
    {
        
        public CreateUserValidator() {
            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.Password).NotNull();
            RuleFor(x => x.Email).NotNull().EmailAddress();
            }
    }
}