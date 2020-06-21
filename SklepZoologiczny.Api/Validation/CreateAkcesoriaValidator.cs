using FluentValidation;
using SklepZoologiczny.IServices.Requests;

namespace SklepZoologiczny.Api.Validation
{
    public class CreateAkcesoriaValidator : AbstractValidator<CreateAkcesoria>
    {

        public CreateAkcesoriaValidator()
        {
            RuleFor(x => x.Nazwa).NotNull();
            RuleFor(x => x.ProducentId).NotNull();
        }
    }
}