using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
    public class KlientConfiguration : IEntityTypeConfiguration<Klient>
    {
        public void Configure(EntityTypeBuilder<Klient> builder)
        {
            
            builder.Property(c => c.KlientId).IsRequired();
            builder.Property(c => c.Imie).IsRequired();
            builder.Property(c => c.Nazwisko).IsRequired();
            builder.Property(c => c.Telefon).IsRequired();
            builder.Property(c => c.Email).IsRequired();
            builder.Property(c => c.Kraj).IsRequired();
            builder.Property(c => c.Miejscowosc).IsRequired();
            builder.Property(c => c.Ulica).IsRequired();
            builder.Property(c => c.Nr_domu).IsRequired();
            builder.Property(c => c.Kodpocztowy).IsRequired();
            
            builder.ToTable ("Klient") ;
        }
    }
}
