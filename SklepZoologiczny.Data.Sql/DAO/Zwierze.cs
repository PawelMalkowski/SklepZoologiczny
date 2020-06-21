using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Api.DAO
{
    public class Zwierze
    {
        public int ZwierzeId { get; set; }
        public int GatunekId { get; set; }
        public int Wiek { get; set; }
        public bool Licencja { get; set; }
        public bool Transport { get; set; }
        public int HodowlaId { get; set; }
        public int DostawcaId { get; set; }

        public virtual Produkt Produkt { get; set; }
        public virtual Gatunek Gatunek { get; set; }
        public virtual Firma Hodowla { get; set; }
        public virtual Firma Dostawca { get; set; }
    }
}
