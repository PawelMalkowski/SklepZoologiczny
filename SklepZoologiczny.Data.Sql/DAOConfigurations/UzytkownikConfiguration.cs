using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
   public class UzytkownikConfiguration: IEntityTypeConfiguration<Uzytkownik>
    {
        public void Configure(EntityTypeBuilder<Uzytkownik> builder)
        {
            builder.Property(c => c.UzytkownikId).IsRequired();
            builder.Property(c => c.Login).IsRequired();
            builder.Property(c => c.Haslo).IsRequired();
             builder.Property(c => c.Email).IsRequired();

            builder.HasOne(x => x.Klients)
                .WithOne(x => x.Uzytkowniks)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<Klient>(b => b.KlientId);

            builder.ToTable("Uzytkownik");
        }
    }
}
