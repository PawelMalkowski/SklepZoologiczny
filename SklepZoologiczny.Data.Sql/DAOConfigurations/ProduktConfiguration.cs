using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
    public class ProduktConfiguration: IEntityTypeConfiguration<Produkt>
    {
        public void Configure(EntityTypeBuilder<Produkt> builder)
        {
            builder.Property(c => c.ProduktId).IsRequired();
            builder.Property(c => c.Ilosc).IsRequired();
            builder.Property(c => c.Waga).IsRequired();

            builder.HasOne(x => x.Zwierzes)
             .WithOne(x => x.Produkt)
             .OnDelete(DeleteBehavior.Restrict)
             .HasForeignKey<Zwierze>(x => x.ZwierzeId);
            builder.HasOne(x => x.Akcesorias)
                .WithOne(x => x.Produkt)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<Akcesoria>(x => x.AkcesoriaId);
            builder.HasOne(x => x.Pokarms)
               .WithOne(x => x.Produkt)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey<Pokarm>(x => x.PokarmID);

            builder.ToTable("Produkt");
        }
    }
}
