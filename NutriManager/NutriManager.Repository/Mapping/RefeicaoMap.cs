using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;
using NutriManager.Repository.Mapping; // Adicione se necessário

public class RefeicaoMap : IEntityTypeConfiguration<Refeicao>
{
    public void Configure(EntityTypeBuilder<Refeicao> builder)
    {

        builder.ToTable("refeicao");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
            .IsRequired()
            .HasMaxLength(45)
            .HasColumnName("descricao");

        builder.Property(x => x.HorarioSugestao)
            .IsRequired()
            .HasColumnName("horario");

        builder.HasOne(x => x.PlanoAlimentar)
            .WithMany(p => p.Refeicoes)
            .HasForeignKey(x => x.PlanoAlimentarId)
            .IsRequired();

        builder.HasMany(x => x.Alimentos)
            .WithOne(a => a.Refeicao) 
            .HasForeignKey(a => a.Id);
    }
}