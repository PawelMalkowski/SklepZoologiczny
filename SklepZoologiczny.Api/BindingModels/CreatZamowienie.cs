using System;
using System.ComponentModel.DataAnnotations;
using SklepZoologiczny.Api.Enums;

namespace SklepZoologiczny.Api.BindingModels
{
    public class CreatZamowienie
    {
        [Required]
        [Display(Name = "Data_zlozenia")]
        public DateTime Data_zlozenia { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }

        [Required]
        [Display(Name = "Przesylka")]
        public string Przesylka { get; set; }


        [Display(Name = "FirmaId")]
        public int FirmaId { get; set; }


        [Display(Name = "KlientId")]
        public int KlientId { get; set; }
    }
}
