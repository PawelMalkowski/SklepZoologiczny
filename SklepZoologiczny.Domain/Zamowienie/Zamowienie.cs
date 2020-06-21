using System;
using System.Collections.Generic;
using System.Text;
using SklepZoologiczny.Domain.DomainExceptions;

namespace SklepZoologiczny.Domain.Zamowienie
{
    public class Zamowienie
    {
        public int Id { get; set; }
        public DateTime Data_zlozenia { get; set; }
        public string Status { get; set; }
        public string Przesylka { get; set; }
        public int FirmaId { get; set; }

        public int KlientId { get; set; }
        public Zamowienie(DateTime data_zlozenia, string status, string przesylka, int firmaId, int klientId)
        {

            Data_zlozenia = data_zlozenia;
            Status = status;
            Przesylka = przesylka;
            FirmaId = firmaId;
            KlientId = klientId;

        }
    }
}
