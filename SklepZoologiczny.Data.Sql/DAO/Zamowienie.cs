using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace SklepZoologiczny.Api.DAO
{
    public class Zamowienie
    {
        public Zamowienie()
        {
            Produkt_Zamowienies = new List<ProduktZamowienie>();
        }
        public int ZamowienieId { get; set; }
        public DateTime Data_zlozenia { get; set; }
        public string Status { get; set; }
        public string Przesylka { get; set; }
        public int FirmaId { get; set; }

        public int KlientId { get; set; }
        public virtual Klient Klient { get; set; }
        public virtual Firma Firma { get; set; }

        public virtual ICollection<ProduktZamowienie> Produkt_Zamowienies { get; set; }


    }
}
