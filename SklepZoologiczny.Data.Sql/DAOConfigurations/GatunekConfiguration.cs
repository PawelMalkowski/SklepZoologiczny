using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
   public class GatunekConfiguration: IEntityTypeConfiguration<Gatunek>
    {
        public void Configure(EntityTypeBuilder<Gatunek> builder)
        {
            builder.Property(c => c.GatunekId).IsRequired();
            builder.Property(c => c.Nazwa).IsRequired();
            builder.ToTable("Gatunek");
        }
    }
}
