using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAO
{
   public class Pokarm_Gatunek
    {
        public int pokarm_gatunekID { get; set; }
        public int GatunekId { get; set; }
        public int PokarmId { get; set; }
        public virtual Gatunek Gatunek { get; set; }
        public virtual Pokarm Pokarm { get; set; }

    }
}
