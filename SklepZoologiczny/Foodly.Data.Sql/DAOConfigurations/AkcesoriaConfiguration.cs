using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    public class AkcesoriaConfiguration: IEntityTypeConfiguration<Akcesoria>
    {
        public void Configure(EntityTypeBuilder<Akcesoria> builder)
        {
            builder.Property(c => c.AkcesoriaId).IsRequired();
            builder.Property(c => c.Nazwa).IsRequired();
            builder.Property(c => c.ProducentId).IsRequired();
            builder.HasOne(x => x.Producents)
                .WithMany(x => x.Akcesorie)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.ProducentId);

            builder.HasOne(x => x.Produkt)
                .WithOne(x => x.Akcesorias)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey<Produkt>(x => x.ProduktId);
                
            builder.ToTable("Akcesoria");
        }
    }
}
