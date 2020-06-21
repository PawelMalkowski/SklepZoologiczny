using System;
using SklepZoologiczny.Api.Enums;

namespace SklepZoologiczny.IServices.Requests
{
    public class CreateZamowienie
    {
        public DateTime Data_zlozenia { get; set; }
        public string Status { get; set; }
        public string Przesylka { get; set; }
        public int FirmaId { get; set; }

        public int KlientId { get; set; }
    }
}
