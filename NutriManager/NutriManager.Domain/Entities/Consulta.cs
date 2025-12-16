using NutriManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Domain.Entities
{
    public class Consulta : BaseEntity<int>
    {
        public Consulta() { }
        public Consulta(int id, DateTime dataConsulta, string objetivo, string observacoes, string observacoesGerais, Bioimpedancia bioimpedancia, DobrasCutaneas dobrasCutaneas, MedidasAntropometricas medidasAntropometricas, PlanoAlimentar planoAlimentar, Paciente paciente)
        {
            Id = id;
            DataConsulta = dataConsulta;
            Objetivo = objetivo;
            Observacoes = observacoes;
            ObservacoesGerais = observacoesGerais;
            Bioimpedancia = bioimpedancia;
            DobrasCutaneas = dobrasCutaneas;
            MedidasAntropometricas = medidasAntropometricas;
            PlanoAlimentar = planoAlimentar;
            Paciente = paciente;
        }

        public DateTime DataConsulta { get; set; }
        public string Objetivo { get; set; }
        public string Observacoes { get; set; }
        public string ObservacoesGerais { get; set; }
        public virtual Bioimpedancia? Bioimpedancia { get; set; }
        public virtual DobrasCutaneas? DobrasCutaneas { get; set; }
        public virtual MedidasAntropometricas? MedidasAntropometricas { get; set; }
        public virtual PlanoAlimentar? PlanoAlimentar { get; set; }
        public virtual Paciente? Paciente { get; set; }
    }
}
