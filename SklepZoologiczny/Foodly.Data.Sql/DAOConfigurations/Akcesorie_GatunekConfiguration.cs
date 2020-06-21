using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    public class Akcesorie_GatunekConfiguration: IEntityTypeConfiguration<Akcesorie_Gatunek>
    {
        public void Configure(EntityTypeBuilder<Akcesorie_Gatunek> builder)
        {
            builder.Property(c => c.Akcesorie_GatunekId).IsRequired();
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
