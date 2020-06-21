using System.Collections.Generic;

namespace SklepZoologiczny.Api.DAO
{
    public class Pokarm
    {
        public Pokarm()
        {
            Pokarm_Gatuneks = new List<PokarmGatunek>();
        }
        public int PokarmID { get; set; }
        public int ProducentId { get; set; }
        public int Kalorie { get; set; }
        public string Nazwa { get; set; }
        public virtual Produkt Produkt { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual ICollection<PokarmGatunek> Pokarm_Gatuneks{get;set;}
    }
}
