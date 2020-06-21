using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SklepZoologiczny.Api.BindingModels
{
    public class CreatAkcesoria
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string Nazwa { get; set; }

        [Required]
        [Display(Name = "ProducentId")]
        public int ProducentId { get; set; }


    }
}
