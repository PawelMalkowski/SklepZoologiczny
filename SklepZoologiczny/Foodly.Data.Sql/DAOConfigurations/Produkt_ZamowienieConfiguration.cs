using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    public class Produkt_ZamowienieConfiguration: IEntityTypeConfiguration<Produkt_Zamowienie>
    {
        public void Configure(EntityTypeBuilder<Produkt_Zamowienie> builder)
        {
            builder.Property(c => c.produkt_zamowienieId).IsRequired();
            builder.Property(c => c.ProdukId).IsRequired();
            builder.Property(c => c.ZamowieniaId).IsRequired();

            builder.HasOne(x => x.Produkt)
                .WithMany(x => x.Produkt_Zamowienies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ProdukId);
            builder.HasOne(x => x.Zamowienia)
                .WithMany(x => x.Produkt_Zamowienies)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ZamowieniaId);
            builder.ToTable("Produkt_Zamowienie");
        }
    }
}
