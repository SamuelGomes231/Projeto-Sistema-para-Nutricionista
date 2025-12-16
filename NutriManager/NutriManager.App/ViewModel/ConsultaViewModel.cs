using System;

namespace NutriManager.App.ViewModel
{
    public class ConsultaViewModel
    {
        public int Id { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Objetivo { get; set; }
        public string Observacoes { get; set; }
        public string ObservacoesGerais { get; set; }
        public int IdPaciente { get; set; }
        public string NomePaciente { get; set; }
        public int? IdPlanoAlimentar { get; set; }
        public string DescricaoPlano { get; set; }
        public int IdMediasAntropometricas { get; set; }
        public int IdBioimpedancia { get; set; }

        public int IdDobrasCutaneas { get; set; }
    }
}