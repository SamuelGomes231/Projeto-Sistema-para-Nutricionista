using System;

namespace NutriManager.App.ViewModel
{
    public class PlanoAlimentarViewModel
    {
        public int Id { get; set; }
        public string DescricaoGeral { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int CaloriasDiarias { get; set; }
        public int RefeicoesPordia { get; set; }
        public int IdPaciente { get; set; }
    }
}