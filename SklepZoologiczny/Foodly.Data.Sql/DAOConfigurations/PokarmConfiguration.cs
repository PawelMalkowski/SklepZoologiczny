using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
   public class PokarmConfiguration:IEntityTypeConfiguration<Pokarm>
    {
        public void Configure(EntityTypeBuilder<Pokarm> builder)
        {
            builder.Property(c => c.PokarmID).IsRequired();
            builder.Property(c => c.ProducentId).IsRequired();
            builder.Property(c => c.Kalorie).IsRequired();
            builder.Property(c => c.Nazwa).IsRequired();

            builder.HasOne(x => x.Produkt)
               .WithOne(x => x.Pokarms)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey<Produkt>(x => x.ProduktId);

            builder.ToTable("Pokarm");
        }

    }
}
