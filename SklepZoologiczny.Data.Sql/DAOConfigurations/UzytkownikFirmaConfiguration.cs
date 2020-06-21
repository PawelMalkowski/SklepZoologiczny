using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
    class UzytkownikFirmaConfiguration: IEntityTypeConfiguration<UzytkownikFirma>
    {
        public void Configure(EntityTypeBuilder<UzytkownikFirma> builder)
        {
            builder.Property(c => c.UzytkownikFirmaId).IsRequired();
            builder.Property(c => c.UzytkownikId).IsRequired();
            builder.Property(c => c.FirmaId).IsRequired();

            builder.HasOne(x => x.Uzytkownik)
                .WithMany(x => x.Uzytkownik_Firmas)
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
