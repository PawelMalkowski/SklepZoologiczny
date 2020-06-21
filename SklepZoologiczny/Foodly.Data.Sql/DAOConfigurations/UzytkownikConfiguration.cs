using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
   public class UzytkownikConfiguration: IEntityTypeConfiguration<Uzytkownik>
    {
        public void Configure(EntityTypeBuilder<Uzytkownik> builder)
        {
            builder.Property(c => c.UzytkownikId).IsRequired();
            builder.Property(c => c.Login).IsRequired();
            builder.Property(c => c.Haslo).IsRequired();
            builder.Property(c => c.Email).IsRequired();

            builder.ToTable("Uzytkownik");
        }
    }
}
