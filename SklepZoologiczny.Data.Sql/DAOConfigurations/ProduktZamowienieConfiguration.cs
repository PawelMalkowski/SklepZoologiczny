using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SklepZoologiczny.Api.DAOConfigurations
{
    public class ProduktZamowienieConfiguration: IEntityTypeConfiguration<ProduktZamowienie>
    {
        public void Configure(EntityTypeBuilder<ProduktZamowienie> builder)
        {
            builder.Property(c => c.ProduktZamowienieId).IsRequired();
            builder.Property(c => c.ProduktId).IsRequired();
            builder.Property(c => c.ZamowienieId).IsRequired();

            builder.HasOne(x => x.Produkt)
                .WithMany(x => x.Produkt_Zamowienies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ProduktId);
            builder.HasOne(x => x.Zamowienie)
                .WithMany(x => x.Produkt_Zamowienies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ZamowienieId);
            builder.ToTable("Produkt_Zamowienie");
        }
    }
}
