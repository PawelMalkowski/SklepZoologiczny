using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Api.DAO
{
   public class ProduktZamowienie
    {
        public int ProduktZamowienieId { get; set; }
        public int ZamowienieId { get; set; }
        public int ProduktId { get; set; }

        public virtual Produkt Produkt { get; set; }
        public virtual Zamowienie Zamowienie { get; set; }
    }
}
