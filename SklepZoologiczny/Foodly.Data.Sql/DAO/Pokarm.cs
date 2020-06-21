using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
    public class Pokarm
    {
        public Pokarm()
        {
            Pokarm_Gatuneks = new List<Pokarm_Gatunek>();
        }
        public int PokarmID { get; set; }
        public int ProducentId { get; set; }
        public int Kalorie { get; set; }
        public string Nazwa { get; set; }
        public virtual Produkt Produkt { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual ICollection<Pokarm_Gatunek> Pokarm_Gatuneks{get;set;}
    }
}
