using SklepZoologiczny.Data.Sql.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Data.Sql.DAOConfigurations
{
    class Pokarm_GatunekConfiguration: IEntityTypeConfiguration<Pokarm_Gatunek>
    {
        public void Configure(EntityTypeBuilder<Pokarm_Gatunek> builder)
        {
            builder.Property(c => c.pokarm_gatunekID).IsRequired();
            builder.Property(c => c.PokarmId).IsRequired();
            builder.Property(c => c.GatunekId).IsRequired();

            builder.HasOne(x => x.Gatunek)
                .WithMany(x => x.Pokarm_Gatuneks)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.GatunekId);
            builder.HasOne(x => x.Pokarm)
                .WithMany(x => x.Pokarm_Gatuneks)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.GatunekId);
            builder.ToTable("Pokarm_Gatunek");
        }
    }
}
