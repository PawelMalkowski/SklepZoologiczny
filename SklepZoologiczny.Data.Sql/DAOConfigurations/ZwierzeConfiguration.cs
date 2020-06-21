using SklepZoologiczny.Api.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SklepZoologiczny.Api.DAOConfigurations
{
    public class ZwierzeConfiguration: IEntityTypeConfiguration<Zwierze>
    {
        public void Configure(EntityTypeBuilder<Zwierze> builder)
        {
            builder.Property(c => c.ZwierzeId).IsRequired();
            builder.Property(c => c.GatunekId).IsRequired();
            builder.Property(c => c.Wiek).IsRequired();
            builder.Property(c => c.Licencja).IsRequired();
            builder.Property(c => c.Transport).IsRequired();
            builder.Property(c => c.HodowlaId).IsRequired();
            builder.Property(c => c.DostawcaId).IsRequired();
            builder.Property(c => c.Licencja).HasColumnType("tinyint(1)");
            builder.Property(c => c.Transport).HasColumnType("tinyint(1)");

            
            builder.HasOne(x => x.Gatunek)
               .WithMany(x => x.Zwierzes)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey(x => x.GatunekId);
            builder.HasOne(x => x.Hodowla)
                .WithMany(x => x.Hodowla)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.HodowlaId);
            builder.HasOne(x => x.Dostawca)
                .WithMany(x => x.Dostawca)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.DostawcaId);
            builder.ToTable("Zwierze");
        }
    }
}
