using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
    public class Uzytkownik
    {
        public Uzytkownik()
        {
            Klients = new Klient();
            uzytkownik_Firmas = new List<Uzytkownik_Firma>();
        }
        public int UzytkownikId { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }

        public virtual Klient Klients { get; set; }
        public virtual ICollection<Uzytkownik_Firma> uzytkownik_Firmas { get; set; }
    }
  
}
