using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
    public class Gatunek
    {
        public Gatunek()
        {
            Pokarm_Gatuneks = new List<Pokarm_Gatunek>();
            Akcesorie_Gatuneks = new List<Akcesorie_Gatunek>();
            Zwierzes = new List<Zwierze>();
        }
        public int GatunekId { get; set; }
        public string Nazwa { get; set; }
        public virtual ICollection<Pokarm_Gatunek> Pokarm_Gatuneks { get; set; }
        public virtual ICollection<Akcesorie_Gatunek> Akcesorie_Gatuneks { get; set; }
        public virtual ICollection<Zwierze> Zwierzes { get; set; }

    }
}
