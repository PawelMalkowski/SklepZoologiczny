using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace SklepZoologiczny.Api.BindingModels
{
    public class EditAkcesoria
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string Nazwa { get; set; }
    }
    public class EditAkcesoriaValidator : AbstractValidator<EditAkcesoria>
    {
        public EditAkcesoriaValidator()
        {
            RuleFor(x => x.Nazwa).NotNull();
        }
    }
}
