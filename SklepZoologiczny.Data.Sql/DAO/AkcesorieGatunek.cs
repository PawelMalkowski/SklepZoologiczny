using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Api.DAO
{
   public class AkcesorieGatunek
    {
        public int AkcesorieGatunekId { get; set; }
        public int AkceorieId { get; set; }
        public int GatunekId { get; set; }
        public virtual Akcesoria Akcesoria { get; set; }
        public virtual Gatunek Gatunek { get; set; }
    }
}
