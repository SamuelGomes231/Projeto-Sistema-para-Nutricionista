using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;

namespace NutriManager.Repository.Mapping
{
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataConsulta)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(x => x.Objetivo)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(x => x.Observacoes)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(x => x.ObservacoesGerais)
                .IsRequired()
                .HasColumnType("varchar(45)");

            // Relacionamento com PlanoAlimentar
            builder.HasOne(x => x.PlanoAlimentar)
                .WithMany()
                .HasForeignKey("x => x.PlanoAlimentarId")
                .IsRequired(false);

            // Relacionamento com Paciente
            builder.HasOne(x => x.Paciente)
                   .WithMany()
                   .HasForeignKey("Paciente_id")
                   .IsRequired();

            // Relacionamento com MedidasAntropométricas
            builder.HasOne(x => x.MedidasAntropometricas)
                .WithMany()
                .HasForeignKey("x => x.MedidasAntropometricasId")
                .IsRequired();

            // Relacionamento com Bioimpedância
            builder.HasOne(x => x.Bioimpedancia)
                .WithMany()
                .HasForeignKey("x => x.BioimpedanciaId")
                .IsRequired();

            // Relacionamento com DobrasCutâneas
            builder.HasOne(x => x.DobrasCutaneas)
                .WithMany()
                .HasForeignKey("x => x.DobrasCutaneasId")
                .IsRequired();
        }
    }
}
