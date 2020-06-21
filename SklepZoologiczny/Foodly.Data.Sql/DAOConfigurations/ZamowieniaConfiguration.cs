using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    public class ZamowieniaConfiguration: IEntityTypeConfiguration<Zamowienie>
    {
        public void Configure(EntityTypeBuilder<Zamowienie> builder)
        {
            builder.Property(c => c.ZamowienieId).IsRequired();
            builder.Property(c => c.Data_zlozenia).IsRequired();
            builder.Property(c => c.Status).IsRequired();
            builder.Property(c => c.Przesylka).IsRequired();

            builder.HasOne(x => x.Klient)
               .WithMany(x => x.Zamowienias)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey(x => x.KlientID);
            builder.HasOne(x => x.Firma)
                .WithMany(x => x.Zamowienie)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ZamowienieId);
            builder.ToTable("Zamowienia");
        }
    }
}
