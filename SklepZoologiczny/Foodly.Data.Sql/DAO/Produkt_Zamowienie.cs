using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
   public class Produkt_Zamowienie
    {
        public int produkt_zamowienieId { get; set; }
        public int ZamowieniaId { get; set; }
        public int ProdukId { get; set; }

        public virtual Produkt Produkt { get; set; }
        public virtual Zamowienie Zamowienia { get; set; }
    }
}
