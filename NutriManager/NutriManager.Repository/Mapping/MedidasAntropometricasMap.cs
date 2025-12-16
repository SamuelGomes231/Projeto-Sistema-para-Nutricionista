using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;

namespace NutriManager.Repository.Mapping
{
    public class MedidasAntropometricasMap : IEntityTypeConfiguration<MedidasAntropometricas>
    {
        public void Configure(EntityTypeBuilder<MedidasAntropometricas> builder)
        {
            builder.ToTable("MedidasAntropometricas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Peso)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.Altura)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaCintura)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaQuadril)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaBracoDireito)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaBracoEsquerdo)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaCoxaDireita)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaCoxaEsquerda)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaPanturrilhaDireita)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(x => x.CircunferenciaPanturrilhaEsquerda)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
        }
    }
}
