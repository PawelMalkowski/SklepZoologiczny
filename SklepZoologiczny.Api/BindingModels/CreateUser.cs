using System;
using System.ComponentModel.DataAnnotations;
using SklepZoologiczny.Api.Enums;

namespace SklepZoologiczny.Api.BindingModels
{
    public class CreateUser
    {
        [Required]
        [Display(Name = "Login")]
        public string Login { get; set; }
        
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        
        [Required]
        [Display(Name = "Haslo")]
        public string Haslo { get; set; }
        

    }
}