using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;

public class PlanoAlimentarMap : IEntityTypeConfiguration<PlanoAlimentar>
{
    public void Configure(EntityTypeBuilder<PlanoAlimentar> builder)
    {
        builder.ToTable("PlanoAlimentar");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.DescricaoGeral)
            .IsRequired()
            .HasColumnType("varchar(45)");

        builder.Property(x => x.DataInicio)
            .IsRequired()
            .HasColumnType("datetime");

        builder.Property(x => x.DataFim)
            .IsRequired()
            .HasColumnType("datetime");

        builder.Property(x => x.CaloriasDiarias)
            .IsRequired();

        builder.Property(x => x.RefeicoesPorDia)
            .IsRequired();

        builder.HasOne(x => x.Paciente)
                .WithMany()
                .HasForeignKey("idPaciente")
                .IsRequired();

    }
}
