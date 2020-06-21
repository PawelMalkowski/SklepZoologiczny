using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace SklepZoologiczny.Api.DAOConfigurations
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

            
                
            builder.ToTable("Akcesoria");
        }
    }
}
