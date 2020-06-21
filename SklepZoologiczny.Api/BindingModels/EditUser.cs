using System;
using System.ComponentModel.DataAnnotations;
using FluentValidation;
using SklepZoologiczny.Api.Enums;

namespace SklepZoologiczny.Api.BindingModels
{
    public class EditUser
    {

        [Display(Name = "Login")]
        public string Login { get; set; }

 


        [Display(Name = "Haslo")]
        public string Haslo { get; set; }
    }

    public class EditUserValidator : AbstractValidator<EditUser>
    {
        public EditUserValidator()
        {
            RuleFor(x => x.Login).NotNull();
            RuleFor(x => x.Haslo).NotNull();
        }
    }
}