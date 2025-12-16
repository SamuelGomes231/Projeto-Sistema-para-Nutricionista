using System;

namespace NutriManager.App.ViewModel
{
    public class RefeicaoViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime HorarioSugestao { get; set; }
        public int IdPlanoAlimentar { get; set; }
        public double TotalCalorias { get; set; }
    }
}