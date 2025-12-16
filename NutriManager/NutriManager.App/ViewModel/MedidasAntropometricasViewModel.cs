namespace NutriManager.App.ViewModel
{
    public class MedidasAntropometricasViewModel
    {
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double CircunferenciaCintura { get; set; }
        public double CircunferenciaQuadril { get; set; }

        public double CircunferenciaBracoDireito { get; set; }
        public double CircunferenciaBracoEsquerdo { get; set; }

        public double CircunferenciaCoxaDireita { get; set; }
        public double CircunferenciaCoxaEsquerda { get; set; }

        public double CircunferenciaPanturrilhaDireita { get; set; }
        public double CircunferenciaPanturrilhaEsquerda { get; set; }
        public double IMC => (Altura > 0) ? Peso / (Altura * Altura) : 0;
    }
}