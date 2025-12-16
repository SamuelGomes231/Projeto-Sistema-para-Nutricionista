using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NutriManager.Domain.Entities;

namespace NutriManager.Repository.Mapping
{
    public class PacienteMap : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {

            builder.ToTable("paciente");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasColumnName("Id");

            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Email).HasMaxLength(100);
            builder.Property(c => c.Telefone).HasMaxLength(20);
            builder.Property(c => c.Sexo).HasMaxLength(20);

            builder.Property(c => c.DataNascimento).IsRequired();
        }
    }
}