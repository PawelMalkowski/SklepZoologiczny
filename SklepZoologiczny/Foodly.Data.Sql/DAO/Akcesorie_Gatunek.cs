using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
   public class Akcesorie_Gatunek
    {
        public int Akcesorie_GatunekId { get; set; }
        public int AkceorieId { get; set; }
        public int GatunekId { get; set; }
        public virtual Akcesoria Akcesoria { get; set; }
        public virtual Gatunek Gatunek { get; set; }
    }
}
