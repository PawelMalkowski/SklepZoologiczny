using System.Collections.Generic;

namespace SklepZoologiczny.Api.DAO
{
    public class Uzytkownik
    {
        public Uzytkownik()
        {

            Uzytkownik_Firmas = new List<UzytkownikFirma>();
        }
        public int UzytkownikId { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Email { get; set; }

        public virtual Klient Klients { get; set; }
        public virtual ICollection<UzytkownikFirma> Uzytkownik_Firmas { get; set; }
    }
  
}
