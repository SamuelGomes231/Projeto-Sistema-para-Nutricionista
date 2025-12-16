using NutriManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NutriManager.Domain.Entities
{
    public class PlanoAlimentar : BaseEntity<int>
    {
        public PlanoAlimentar()
        {
            Refeicoes = new List<Refeicao>();
        }

        // Atualizei o construtor para aceitar o pacienteId também
        public PlanoAlimentar(int id, string descricaoGeral, DateTime dataInicio, DateTime dataFim, int caloriasDiarias, int refeicoesPorDia, int pacienteId)
        {
            Id = id;
            DescricaoGeral = descricaoGeral;
            DataInicio = dataInicio;
            DataFim = dataFim;
            CaloriasDiarias = caloriasDiarias;
            RefeicoesPorDia = refeicoesPorDia;
            Refeicoes = new List<Refeicao>();
        }

        public string DescricaoGeral { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int CaloriasDiarias { get; set; }
        public int RefeicoesPorDia { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual ICollection<Refeicao> Refeicoes { get; set; }
    }
}