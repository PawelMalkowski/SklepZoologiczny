using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
   public class Produkt
    {
        public Produkt()
        {
            Pokarms = new Pokarm();
            Zwierzes =new Zwierze();
            Akcesorias = new Akcesoria();
            Produkt_Zamowienies = new List<Produkt_Zamowienie>();
        }
        public int ProduktId { get; set; }
        public int Ilosc { get; set; }
        public int Waga { get; set; }
        public int Cena { get; set; }

     
        public virtual ICollection<Produkt_Zamowienie> Produkt_Zamowienies { get; set; }
        public virtual Pokarm Pokarms { get; set; }
        public virtual Zwierze Zwierzes { get; set; }
        public virtual Akcesoria Akcesorias { get; set; }

    }
}
