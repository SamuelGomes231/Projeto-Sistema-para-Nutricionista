using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities; // Ajuste conforme organização do seu projeto

namespace NutriManager.Repository.Mapping
{
    public class BioimpedanciaMap : IEntityTypeConfiguration<Bioimpedancia>
    {
        public void Configure(EntityTypeBuilder<Bioimpedancia> builder)
        {
            builder.ToTable("Bioimpedancia");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.PercentualGordura)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.PercentualMassaMagra)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.PercentualAguaCorporal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.MassaGorda)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.MassaMagra)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.TaxaMetabolicaBasal)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
        }
    }
}
