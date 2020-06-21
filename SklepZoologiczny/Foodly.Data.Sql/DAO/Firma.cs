using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
    public class Firma
    {
        public Firma()
        {
            Hodowla = new List<Zwierze>();
            Dostawca = new List<Zwierze>();
            Producent = new List<Pokarm>();
            Akcesorie = new List<Akcesoria>();
            Zamowienie = new List<Zamowienie>();
            Uzytkownik_Firmas = new List<Uzytkownik_Firma>();
        }

        public int FirmaId { get; set; }
        public string Nazwa { get; set; }
        public string Nip { get; set; }
        public string Kraj { get; set; }
        public string Miejscowosc { get; set; }
        public string Ulica { get; set; }
        public string Nr_domu { get; set; }
        public string Nr_mieszkania { get; set; }
        public string Kodpocztowy { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Uzytkownik_Firma> Uzytkownik_Firmas { get; set; }
        public virtual ICollection<Zwierze> Hodowla { get; set; }
        public virtual ICollection<Zwierze> Dostawca { get; set; }
        public virtual ICollection<Pokarm> Producent { get; set; }
        public virtual ICollection<Akcesoria> Akcesorie { get; set; }
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
