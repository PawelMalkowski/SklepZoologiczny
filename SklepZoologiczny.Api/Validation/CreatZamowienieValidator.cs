using FluentValidation;
using SklepZoologiczny.IServices.Requests;

namespace SklepZoologiczny.Api.Validation
{
    public class CreatZamowienieValidator : AbstractValidator<CreateZamowienie>
    {

        public CreatZamowienieValidator()
        {
            RuleFor(x => x.Data_zlozenia).NotNull();
            RuleFor(x => x.Status).NotNull();
            RuleFor(x => x.Przesylka).NotNull().EmailAddress();
        }
    }
}