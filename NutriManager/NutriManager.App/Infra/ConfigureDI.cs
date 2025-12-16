using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using NutriManager.App.Pages;
using NutriManager.App.Register;
using NutriManager.App.ViewModel;
using NutriManager.Domain.Base;
using NutriManager.Domain.Entities;
using NutriManager.Repository;
using NutriManager.Repository.Context;
using NutriManager.Service.Services;
using System;
using System.IO;

namespace NutriManager.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            var dbConfigFile = "Config/DBConfig.txt";
            string strCon;

            if (File.Exists(dbConfigFile))
            {
                strCon = File.ReadAllText(dbConfigFile);
            }
            else
            {
                strCon = "server=localhost;database=nutrimanager;user=root;password=";
            }

            services = new ServiceCollection();

            services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseMySQL(strCon);
            });

            // 2. Repositórios
            services.AddScoped<IBaseRepository<Paciente>, BaseRepository<Paciente>>();
            services.AddScoped<IBaseRepository<Alimento>, BaseRepository<Alimento>>();
            services.AddScoped<IBaseRepository<PlanoAlimentar>, BaseRepository<PlanoAlimentar>>();
            services.AddScoped<IBaseRepository<Refeicao>, BaseRepository<Refeicao>>();
            services.AddScoped<IBaseRepository<Consulta>, BaseRepository<Consulta>>();

            services.AddScoped<IBaseRepository<MedidasAntropometricas>, BaseRepository<MedidasAntropometricas>>();
            services.AddScoped<IBaseRepository<Bioimpedancia>, BaseRepository<Bioimpedancia>>();
            services.AddScoped<IBaseRepository<DobrasCutaneas>, BaseRepository<DobrasCutaneas>>();

            // 3. Serviços
            services.AddScoped<IBaseService<Paciente>, BaseService<Paciente>>();
            services.AddScoped<IBaseService<Alimento>, BaseService<Alimento>>();
            services.AddScoped<IBaseService<PlanoAlimentar>, BaseService<PlanoAlimentar>>();
            services.AddScoped<IBaseService<Refeicao>, BaseService<Refeicao>>();
            services.AddScoped<IBaseService<Consulta>, BaseService<Consulta>>();

            services.AddScoped<IBaseService<MedidasAntropometricas>, BaseService<MedidasAntropometricas>>();
            services.AddScoped<IBaseService<Bioimpedancia>, BaseService<Bioimpedancia>>();
            services.AddScoped<IBaseService<DobrasCutaneas>, BaseService<DobrasCutaneas>>();

            // 4. Formulários
            services.AddTransient<MainForm, MainForm>();
            services.AddTransient<PacienteForm, PacienteForm>();
            services.AddTransient<AlimentoForm, AlimentoForm>(); 
            services.AddTransient<ConsultaForm, ConsultaForm>();
            services.AddTransient<ProntuarioForm, ProntuarioForm>();
            services.AddTransient<PlanoAlimentarForm, PlanoAlimentarForm>();
            services.AddScoped<IBaseService<RefeicaoAlimento>, BaseService<RefeicaoAlimento>>();
            services.AddScoped<IBaseRepository<RefeicaoAlimento>, BaseRepository<RefeicaoAlimento>>();

            // 5. Configuração do AutoMapper
            services.AddSingleton(new MapperConfiguration(config =>
            {
                // --- Paciente ---
                config.CreateMap<Paciente, PacienteViewModel>();
                config.CreateMap<PacienteViewModel, Paciente>();

                // --- Alimento ---
                config.CreateMap<Alimento, AlimentoViewModel>();
                config.CreateMap<AlimentoViewModel, Alimento>();

                // --- Plano Alimentar ---
                config.CreateMap<PlanoAlimentar, PlanoAlimentarViewModel>();
                config.CreateMap<PlanoAlimentarViewModel, PlanoAlimentar>();

                // --- Medidas e Bioimpedância ---
                config.CreateMap<MedidasAntropometricas, MedidasAntropometricasViewModel>();
                config.CreateMap<MedidasAntropometricasViewModel, MedidasAntropometricas>();

                config.CreateMap<Bioimpedancia, BioimpedanciaViewModel>();
                config.CreateMap<BioimpedanciaViewModel, Bioimpedancia>();

                // --- Dobras Cutâneas ---
                config.CreateMap<DobrasCutaneas, DobrasCutaneasViewModel>();
                config.CreateMap<DobrasCutaneasViewModel, DobrasCutaneas>();

                // --- Refeição ---
                config.CreateMap<Refeicao, RefeicaoViewModel>()
                    .ForMember(d => d.IdPlanoAlimentar, opt => opt.MapFrom(src => src.PlanoAlimentar.Id));
                config.CreateMap<RefeicaoViewModel, Refeicao>();

                // --- Consulta ---
                config.CreateMap<Consulta, ConsultaViewModel>()
                    // Paciente
                    .ForMember(d => d.IdPaciente, opt => opt.MapFrom(src => src.Paciente.Id))
                    .ForMember(d => d.NomePaciente, opt => opt.MapFrom(src => src.Paciente.Nome))

                    // Plano Alimentar
                    .ForMember(d => d.IdPlanoAlimentar, opt => opt.MapFrom(src => src.PlanoAlimentar != null ? src.PlanoAlimentar.Id : (int?)null))

                    // Medidas
                    .ForMember(d => d.IdMediasAntropometricas, opt => opt.MapFrom(src => src.MedidasAntropometricas != null ? src.MedidasAntropometricas.Id : (int?)null))
                    .ForMember(d => d.IdBioimpedancia, opt => opt.MapFrom(src => src.Bioimpedancia != null ? src.Bioimpedancia.Id : (int?)null));

                config.CreateMap<ConsultaViewModel, Consulta>();

            }, NullLoggerFactory.Instance).CreateMapper());

            serviceProvider = services.BuildServiceProvider();
        }
    }
}