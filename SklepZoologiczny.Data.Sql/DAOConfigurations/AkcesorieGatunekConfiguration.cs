using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
    public class AkcesorieGatunekConfiguration: IEntityTypeConfiguration<AkcesorieGatunek>
    {
        public void Configure(EntityTypeBuilder<AkcesorieGatunek> builder)
        {
            builder.Property(c => c.AkcesorieGatunekId).IsRequired();
            builder.Property(c => c.AkceorieId).IsRequired();
            builder.Property(c => c.GatunekId).IsRequired();

            builder.HasOne(x => x.Akcesoria)
               .WithMany(x => x.Akcesorie_Gatuneks)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey(x => x.GatunekId);
            builder.HasOne(x => x.Gatunek)
                .WithMany(x => x.Akcesorie_Gatuneks)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.AkceorieId);
            builder.ToTable("Akcesorie_Gatunek");
        }
    }
}
