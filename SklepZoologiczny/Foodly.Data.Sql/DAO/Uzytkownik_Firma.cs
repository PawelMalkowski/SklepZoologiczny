using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
   public class Uzytkownik_Firma
    {
        public int uzytkownik_FirmaId { get; set; }
        public int UzytkownikId { get; set; }
        public int FirmaId { get; set; }

        public virtual Uzytkownik Uzytkownik { get; set; }
        public virtual Firma Firma { get; set; }
    }
}
