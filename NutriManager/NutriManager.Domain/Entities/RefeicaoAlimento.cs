using System.Text.Json.Serialization;
using NutriManager.Domain.Base;

namespace NutriManager.Domain.Entities
{
    // VOLTAMOS com a herança para o Service aceitar a classe
    public class RefeicaoAlimento : BaseEntity <int>
    {
        public RefeicaoAlimento() { }

        public RefeicaoAlimento(int alimentoId, string porcao, int refeicaoId)
        {
            AlimentoId = alimentoId;
            Porcao = porcao;
            RefeicaoId = refeicaoId;
        }

        public int AlimentoId { get; set; }
        public virtual Alimento Alimento { get; set; }

        public int RefeicaoId { get; set; }

        [JsonIgnore]
        public virtual Refeicao Refeicao { get; set; }

        public string Porcao { get; set; }
    }
}