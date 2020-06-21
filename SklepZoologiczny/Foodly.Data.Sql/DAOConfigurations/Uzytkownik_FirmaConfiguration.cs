using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    class Uzytkownik_FirmaConfiguration: IEntityTypeConfiguration<Uzytkownik_Firma>
    {
        public void Configure(EntityTypeBuilder<Uzytkownik_Firma> builder)
        {
            builder.Property(c => c.uzytkownik_FirmaId).IsRequired();
            builder.Property(c => c.UzytkownikId).IsRequired();
            builder.Property(c => c.FirmaId).IsRequired();

            builder.HasOne(x => x.Uzytkownik)
                .WithMany(x => x.uzytkownik_Firmas)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.UzytkownikId);
            builder.HasOne(x => x.Firma)
                .WithMany(x => x.Uzytkownik_Firmas)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.FirmaId);
            builder.ToTable("Uzytkownik_Firma");
        }
    }
}
