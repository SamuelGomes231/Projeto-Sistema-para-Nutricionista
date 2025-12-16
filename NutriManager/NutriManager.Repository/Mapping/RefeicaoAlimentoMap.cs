using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;

namespace NutriManager.Repository.Mapping
{
    public class RefeicaoAlimentoMap : IEntityTypeConfiguration<RefeicaoAlimento>
    {
        public void Configure(EntityTypeBuilder<RefeicaoAlimento> builder)
        {
            builder.ToTable("alimento_has_refeicao");

            builder.Ignore(x => x.Id);

            builder.HasKey(ra => new { ra.RefeicaoId, ra.AlimentoId });

            builder.Property(ra => ra.AlimentoId)
                   .HasColumnName("Alimento_idAlimento")
                   .IsRequired();

            builder.Property(ra => ra.RefeicaoId)
                   .HasColumnName("Refeicao_idRefeicao")
                   .IsRequired();

            builder.Property(ra => ra.Porcao)
                   .HasColumnName("porcao")
                   .HasMaxLength(45);

            builder.HasOne(ra => ra.Alimento)
                .WithMany()
                .HasForeignKey(ra => ra.AlimentoId);

            builder.HasOne(ra => ra.Refeicao)
                .WithMany(r => r.Alimentos)
                .HasForeignKey(ra => ra.RefeicaoId);
        }
    }
}