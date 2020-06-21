using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Api.DAO
{
   public class Klient
    {
        public Klient()
        {
            Zamowienies = new List<Zamowienie>();
        }
        public int KlientId { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Kraj { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string Nr_domu { get; set; }
        public string Nr_mieszkania { get; set; }
        public string Kodpocztowy { get; set; }


        public virtual ICollection<Zamowienie> Zamowienies { get; set; }
        public virtual Uzytkownik Uzytkowniks { get; set; }
    }
}
