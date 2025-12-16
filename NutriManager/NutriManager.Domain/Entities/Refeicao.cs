using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using NutriManager.Domain.Base;

namespace NutriManager.Domain.Entities
{
    public class Refeicao : BaseEntity<int>
    {
        public Refeicao() { }

        public Refeicao(int id, string nome, DateTime horarioSugestao, int planoAlimentarId, PlanoAlimentar planoAlimentar)
        {
            Id = id;
            Nome = nome;
            HorarioSugestao = horarioSugestao;
            PlanoAlimentarId = planoAlimentarId;
            PlanoAlimentar = planoAlimentar;
            Alimentos = new List<RefeicaoAlimento>();
        }

        public string Nome { get; set; }
        public DateTime HorarioSugestao { get; set; }
        public int PlanoAlimentarId { get; set; }
        public virtual PlanoAlimentar PlanoAlimentar { get; set; }
        public virtual ICollection<RefeicaoAlimento> Alimentos { get; set; }
    }
}
