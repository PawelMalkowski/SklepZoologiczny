using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Api.DAO
{
   public class Produkt
    {
        public Produkt()
        {
            Produkt_Zamowienies = new List<ProduktZamowienie>();
        }
        public int ProduktId { get; set; }
        public int Ilosc { get; set; }
        public int Waga { get; set; }
        public int Cena { get; set; }

     
        public virtual ICollection<ProduktZamowienie> Produkt_Zamowienies { get; set; }
        public virtual Pokarm Pokarms { get; set; }
        public virtual Zwierze Zwierzes { get; set; }
        public virtual Akcesoria Akcesorias { get; set; }

    }
}
