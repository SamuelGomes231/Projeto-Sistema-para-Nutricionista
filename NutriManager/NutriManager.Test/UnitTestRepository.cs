using Microsoft.EntityFrameworkCore;
using NutriManager.Domain.Entities;
using NutriManager.Repository.Mapping;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Linq;
using System.Text.Json;

namespace NutriManager.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Paciente> Pacientes { get; set; }
            public DbSet<Alimento> Alimentos { get; set; }
            public DbSet<PlanoAlimentar> PlanosAlimentares { get; set; }
            public DbSet<Refeicao> Refeicoes { get; set; }
            public DbSet<RefeicaoAlimento> RefeicaoAlimentos { get; set; }
            public DbSet<Bioimpedancia> Bioimpedancias { get; set; }
            public DbSet<DobrasCutaneas> DobrasCutaneas { get; set; }
            public DbSet<MedidasAntropometricas> MedidasAntropometricas { get; set; }
            public DbSet<Consulta> Consultas { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "NutriManager";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Inclua os mappings de cada entidade conforme seu projeto
                modelBuilder.Entity<Paciente>(new PacienteMap().Configure);
                modelBuilder.Entity<Alimento>(new AlimentoMap().Configure);
                modelBuilder.Entity<PlanoAlimentar>(new PlanoAlimentarMap().Configure);
                modelBuilder.Entity<Refeicao>(new RefeicaoMap().Configure);
                modelBuilder.Entity<RefeicaoAlimento>(new RefeicaoAlimentoMap().Configure);
                modelBuilder.Entity<Bioimpedancia>(new BioimpedanciaMap().Configure);
                modelBuilder.Entity<DobrasCutaneas>(new DobrasCutaneasMap().Configure);
                modelBuilder.Entity<MedidasAntropometricas>(new MedidasAntropometricasMap().Configure);
                modelBuilder.Entity<Consulta>(new ConsultaMap().Configure);
            }
        }

        [TestMethod]
        public void TestInsertPacientes()
        {
            using (var context = new MyDbContext())
            {
                context.Pacientes.Add(new Paciente
                {
                    Nome = "João Silva",
                    DataNascimento = new DateTime(1985, 5, 10),
                    Sexo = "Masculino",
                    Telefone = "11999999999",
                    Email = "joao@email.com"
                });
                context.Pacientes.Add(new Paciente
                {
                    Nome = "Maria Souza",
                    DataNascimento = new DateTime(1992, 1, 14),
                    Sexo = "Feminino",
                    Telefone = "11988888888",
                    Email = "maria@email.com"
                });
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListPacientes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var paciente in context.Pacientes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(paciente));
                }
            }
        }

        [TestMethod]
        public void TestInsertAlimentos()
        {
            using (var context = new MyDbContext())
            {
                context.Alimentos.Add(new Alimento
                {
                    Nome = "Arroz",
                    Porcao = "100g",
                    Calorias = 130,
                    Proteinas = 2.7m,
                    Carboidratos = 28m,
                    Gorduras = 0.3m
                });
                context.Alimentos.Add(new Alimento
                {
                    Nome = "Feijão",
                    Porcao = "100g",
                    Calorias = 76,
                    Proteinas = 4.9m,
                    Carboidratos = 14m,
                    Gorduras = 0.3m
                });
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAlimentos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var alimento in context.Alimentos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(alimento));
                }
            }
        }

        [TestMethod]
        public void TestInsertPlanosAlimentares()
        {
            using (var context = new MyDbContext())
            {
                context.PlanosAlimentares.Add(new PlanoAlimentar
                {
                    DescricaoGeral = "Plano básico do João",
                    DataInicio = DateTime.Today,
                    DataFim = DateTime.Today.AddMonths(1),
                    CaloriasDiarias = 2000,
                    RefeicoesPorDia = 6
                });
                context.PlanosAlimentares.Add(new PlanoAlimentar
                {
                    DescricaoGeral = "Plano da Maria",
                    DataInicio = DateTime.Today,
                    DataFim = DateTime.Today.AddMonths(2),
                    CaloriasDiarias = 1800,
                    RefeicoesPorDia = 5
                });
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListPlanosAlimentares()
        {
            using (var context = new MyDbContext())
            {
                foreach (var plano in context.PlanosAlimentares)
                {
                    Console.WriteLine(JsonSerializer.Serialize(plano));
                }
            }
        }

        [TestMethod]
        public void TestInsertRefeicoes()
        {
            using (var context = new MyDbContext())
            {
                var plano = context.PlanosAlimentares.FirstOrDefault();
                context.Refeicoes.Add(new Refeicao
                {
                    Nome = "Café da manhã",
                    HorarioSugestao = DateTime.Today.AddHours(7),
                    PlanoAlimentar = plano
                });
                context.Refeicoes.Add(new Refeicao
                {
                    Nome = "Almoço",
                    HorarioSugestao = DateTime.Today.AddHours(12),
                    PlanoAlimentar = plano
                });
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListRefeicoes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var refeicao in context.Refeicoes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(refeicao));
                }
            }
        }

        [TestMethod]
        public void TestInsertBioimpedancias()
        {
            using (var context = new MyDbContext())
            {
                context.Bioimpedancias.Add(new Bioimpedancia
                {
                    PercentualGordura = 18.5f,
                    PercentualMassaMagra = 45.2f,
                    PercentualAguaCorporal = 60.3f,
                    MassaGorda = 15.5f,
                    MassaMagra = 38.2f,
                    TaxaMetabolicaBasal = 1600f
                });
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListBioimpedancias()
        {
            using (var context = new MyDbContext())
            {
                foreach (var bio in context.Bioimpedancias)
                {
                    Console.WriteLine(JsonSerializer.Serialize(bio));
                }
            }
        }

        [TestMethod]
        public void TestInsertDobrasCutaneas()
        {
            using (var context = new MyDbContext())
            {
                context.DobrasCutaneas.Add(new DobrasCutaneas
                {
                    DobraTricipital = 8.2f,
                    DobraSubescapular = 10.1f,
                    DobraSuprailiaca = 12.0f,
                    DobraAbdominal = 14.5f,
                    DobraCoxa = 16.7f
                });
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListDobrasCutaneas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var dc in context.DobrasCutaneas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(dc));
                }
            }
        }

        [TestMethod]
        public void TestInsertMedidasAntropometricas()
        {
            using (var context = new MyDbContext())
            {
                context.MedidasAntropometricas.Add(new MedidasAntropometricas
                {
                    Peso = 70.2f,
                    Altura = 1.75f,
                    CircunferenciaCintura = 85.3f,
                    CircunferenciaQuadril = 92.5f,
                    CircunferenciaBracoDireito = 28.1f,
                    CircunferenciaBracoEsquerdo = 27.8f,
                    CircunferenciaCoxaDireita = 52.0f,
                    CircunferenciaCoxaEsquerda = 51.5f,
                    CircunferenciaPanturrilhaDireita = 36.6f,
                    CircunferenciaPanturrilhaEsquerda = 36.2f
                });
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListMedidasAntropometricas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var med in context.MedidasAntropometricas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(med));
                }
            }
        }

        [TestMethod]
        public void TestInsertConsultas()
        {
            using (var context = new MyDbContext())
            {
                var paciente = context.Pacientes.FirstOrDefault();
                var plano = context.PlanosAlimentares.FirstOrDefault();
                var bio = context.Bioimpedancias.FirstOrDefault();
                var dobras = context.DobrasCutaneas.FirstOrDefault();
                var medidas = context.MedidasAntropometricas.FirstOrDefault();

                context.Consultas.Add(new Consulta(
                    0,
                    DateTime.Now,
                    "Emagrecimento",
                    "Precisa reduzir medidas!",
                    "Exercícios recomendados.",
                    bio,
                    dobras,
                    medidas,
                    plano,
                    paciente
                ));
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListConsultas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var consulta in context.Consultas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(consulta));
                }
            }
        }
    }
}
