using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAO
{
   public class PokarmGatunek
    {
        public int PokarmGatunekID { get; set; }
        public int GatunekId { get; set; }
        public int PokarmId { get; set; }
        public virtual Gatunek Gatunek { get; set; }
        public virtual Pokarm Pokarm { get; set; }

    }
}
