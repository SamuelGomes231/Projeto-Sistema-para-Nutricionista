using NutriManager.Domain.Base;

namespace NutriManager.Domain.Entities
{
    public class Alimento : BaseEntity<int>
    {
        public Alimento() { }
        public Alimento(int id, string nome, string porcao, decimal calorias, decimal proteinas, decimal carboidratos, decimal gorduras)
        {
            Id = id;
            Nome = nome;
            Porcao = porcao;
            Calorias = calorias;
            Proteinas = proteinas;
            Carboidratos = carboidratos;
            Gorduras = gorduras;
            Refeicoes = new List<RefeicaoAlimento>();
        }

        public string Nome { get; set; }
        public string Porcao { get; set; }
        public decimal Calorias { get; set; }
        public decimal Proteinas { get; set; }
        public decimal Carboidratos { get; set; }
        public decimal Gorduras { get; set; }
        public virtual ICollection<RefeicaoAlimento> Refeicoes { get; set; }

    }
}
