using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    public class ProduktConfiguration: IEntityTypeConfiguration<Produkt>
    {
        public void Configure(EntityTypeBuilder<Produkt> builder)
        {
            builder.Property(c => c.ProduktId).IsRequired();
            builder.Property(c => c.Ilosc).IsRequired();
            builder.Property(c => c.Waga).IsRequired();

            builder.ToTable("Produkt");
        }
    }
}
