using System;
using System.Collections.Generic;
using System.Text;

namespace SklepZoologiczny.Data.Sql.DAO
{
   public class Akcesoria
    {
        public Akcesoria()
        {
            Akcesorie_Gatuneks = new List<Akcesorie_Gatunek>();
        }
        public int AkcesoriaId { get; set; }
        public string Nazwa { get; set; }
        public int ProducentId { get; set; }
        public virtual Produkt Produkt { get; set; }
        public virtual Firma Producents { get; set; }
        public virtual ICollection<Akcesorie_Gatunek> Akcesorie_Gatuneks { get; set; }

    }
}
