using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
    public class ZamowienieConfiguration: IEntityTypeConfiguration<Zamowienie>
    {
        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder.Property(c => c.ZamowienieId).IsRequired();
            builder.Property(c => c.Data_zlozenia).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.Przesylka).IsRequired();

            builder.HasOne(x => x.Klient)
               .WithMany(x => x.Zamowienies)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey(x => x.KlientId);
            builder.HasOne(x => x.Firma)
                .WithMany(x => x.Zamowienies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.FirmaId);
            builder.ToTable("Zamowienie");
        }
    }
}
