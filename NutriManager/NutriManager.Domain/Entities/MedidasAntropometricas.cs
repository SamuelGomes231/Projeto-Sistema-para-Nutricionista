using NutriManager.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriManager.Domain.Entities
{
    public class MedidasAntropometricas : BaseEntity<int>
    {
        public MedidasAntropometricas() { }
        public MedidasAntropometricas(int id, float peso, float altura, float circunferenciaCintura, float circunferenciaQuadril, float circunferenciaBracoDireito, float circunferenciaBracoEsquerdo, float circunferenciaCoxaDireita, float circunferenciaCoxaEsquerda, float circunferenciaPanturrilhaDireita, float circunferenciaPanturrilhaEsquerda)
        {
            Id = id;
            Peso = peso;
            Altura = altura;
            CircunferenciaCintura = circunferenciaCintura;
            CircunferenciaQuadril = circunferenciaQuadril;
            CircunferenciaBracoDireito = circunferenciaBracoDireito;
            CircunferenciaBracoEsquerdo = circunferenciaBracoEsquerdo;
            CircunferenciaCoxaDireita = circunferenciaCoxaDireita;
            CircunferenciaCoxaEsquerda = circunferenciaCoxaEsquerda;
            CircunferenciaPanturrilhaDireita = circunferenciaPanturrilhaDireita;
            CircunferenciaPanturrilhaEsquerda = circunferenciaPanturrilhaEsquerda;
        }

        public float Peso { get; set; }
        public float Altura { get; set; }
        public float CircunferenciaCintura { get; set; }
        public float CircunferenciaQuadril { get; set; }
        public float CircunferenciaBracoDireito { get; set; }
        public float CircunferenciaBracoEsquerdo { get; set; }
        public float CircunferenciaCoxaDireita { get; set; }
        public float CircunferenciaCoxaEsquerda { get; set; }
        public float CircunferenciaPanturrilhaDireita { get; set; }
        public float CircunferenciaPanturrilhaEsquerda { get; set; }
    }
}
