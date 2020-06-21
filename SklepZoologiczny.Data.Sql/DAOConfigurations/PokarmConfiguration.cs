using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
   public class PokarmConfiguration:IEntityTypeConfiguration<Pokarm>
    {
        public void Configure(EntityTypeBuilder<Pokarm> builder)
        {
            builder.Property(c => c.PokarmID).IsRequired();
            builder.Property(c => c.ProducentId).IsRequired();
            builder.Property(c => c.Kalorie).IsRequired();
            builder.Property(c => c.Nazwa).IsRequired();
            builder.HasOne(x => x.Firma)
                .WithMany(x => x.Producent)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ProducentId);


            builder.ToTable("Pokarm");
        }

    }
}
