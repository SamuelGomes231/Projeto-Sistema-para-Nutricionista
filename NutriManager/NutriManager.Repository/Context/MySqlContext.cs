using Microsoft.EntityFrameworkCore;
using NutriManager.Domain.Entities;
using NutriManager.Repository.Mapping;

namespace NutriManager.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<PlanoAlimentar> PlanosAlimentares { get; set; }
        public DbSet<Refeicao> Refeicoes { get; set; }
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<RefeicaoAlimento> RefeicaoAlimentos { get; set; }
        public DbSet<Bioimpedancia> Bioimpedancias { get; set; }
        public DbSet<DobrasCutaneas> DobrasCutaneas { get; set; }
        public DbSet<MedidasAntropometricas> MedidasAntropometricas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Paciente>(new PacienteMap().Configure);
            modelBuilder.Entity<Consulta>(new ConsultaMap().Configure);
            modelBuilder.Entity<PlanoAlimentar>(new PlanoAlimentarMap().Configure);
            modelBuilder.Entity<Refeicao>(new RefeicaoMap().Configure);
            modelBuilder.Entity<Alimento>(new AlimentoMap().Configure);
            modelBuilder.Entity<RefeicaoAlimento>(new RefeicaoAlimentoMap().Configure);
            modelBuilder.Entity<Bioimpedancia>(new BioimpedanciaMap().Configure);
            modelBuilder.Entity<DobrasCutaneas>(new DobrasCutaneasMap().Configure);
            modelBuilder.Entity<MedidasAntropometricas>(new MedidasAntropometricasMap().Configure);
        }
    }
}
