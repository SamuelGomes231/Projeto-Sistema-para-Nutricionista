using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;

namespace NutriManager.Repository.Mapping
{
    public class AlimentoMap : IEntityTypeConfiguration<Alimento>
    {
        public void Configure(EntityTypeBuilder<Alimento> builder)
        {
            builder.ToTable("Alimento");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Porcao)
                .IsRequired()
                .HasColumnType("varchar(45)");

            builder.Property(prop => prop.Calorias)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Proteinas)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Carboidratos)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(prop => prop.Gorduras)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
        }
    }
}
