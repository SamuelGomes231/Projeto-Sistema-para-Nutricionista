using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;

namespace NutriManager.Repository.Mapping
{
    public class DobrasCutaneasMap : IEntityTypeConfiguration<DobrasCutaneas>
    {
        public void Configure(EntityTypeBuilder<DobrasCutaneas> builder)
        {
            builder.ToTable("DobrasCutaneas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DobraTricipital)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.DobraSubescapular)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.DobraSuprailiaca)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.DobraAbdominal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.DobraCoxa)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
        }
    }
}
