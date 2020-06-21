using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Api.DAO
{
    public class Gatunek
    {
        public Gatunek()
        {
            Pokarm_Gatuneks = new List<PokarmGatunek>();
            Akcesorie_Gatuneks = new List<AkcesorieGatunek>();
            Zwierzes = new List<Zwierze>();
        }
        public int GatunekId { get; set; }
        public string Nazwa { get; set; }
        public virtual ICollection<PokarmGatunek> Pokarm_Gatuneks { get; set; }
        public virtual ICollection<AkcesorieGatunek> Akcesorie_Gatuneks { get; set; }
        public virtual ICollection<Zwierze> Zwierzes { get; set; }

    }
}
