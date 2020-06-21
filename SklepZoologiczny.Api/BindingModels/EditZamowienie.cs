using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace SklepZoologiczny.Api.BindingModels
{
    public class EditZamowienie
    {
        [Display(Name = "KlientId")]
        public int KlientId { get; set; }
    }
    public class EditZamowienieValidator : AbstractValidator<EditZamowienie>
    {
        public EditZamowienieValidator()
        {
            RuleFor(x => x.KlientId).NotNull();
        }
    }

}
