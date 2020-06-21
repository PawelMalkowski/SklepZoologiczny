using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    public class FirmaConfiguration: IEntityTypeConfiguration<Firma>
    {
        public void Configure(EntityTypeBuilder<Firma> builder)
        {
            builder.Property(c => c.FirmaId).IsRequired();
            builder.Property(c => c.Nazwa).IsRequired();
            builder.Property(c => c.Nip).IsRequired();
            builder.Property(c => c.Kraj).IsRequired();
            builder.Property(c => c.Miejscowosc).IsRequired();
            builder.Property(c => c.Ulica).IsRequired();
            builder.Property(c => c.Nr_domu).IsRequired();
            builder.Property(c => c.Kodpocztowy).IsRequired();
            builder.Property(c => c.Telefon).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.ToTable("Firma");
        }
    }
}
