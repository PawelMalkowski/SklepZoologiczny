using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
    class PokarmGatunekConfiguration: IEntityTypeConfiguration<PokarmGatunek>
    {
        public void Configure(EntityTypeBuilder<PokarmGatunek> builder)
        {
            builder.Property(c => c.PokarmGatunekID).IsRequired();
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
