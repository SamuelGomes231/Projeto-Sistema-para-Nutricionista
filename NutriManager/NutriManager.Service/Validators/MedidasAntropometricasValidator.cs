using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class MedidasValidator : AbstractValidator<MedidasAntropometricas>
    {
        public MedidasValidator()
        {
            // --- Campos Obrigatórios (Peso e Altura) ---
            RuleFor(x => x.Peso)
                .GreaterThan(0)
                .WithMessage("O Peso deve ser maior que zero.");

            RuleFor(x => x.Altura)
                .GreaterThan(0)
                .WithMessage("A Altura deve ser maior que zero.");

            // --- Circunferências (Validação de não-negativo) ---
            // Usamos GreaterThanOrEqualTo(0) para permitir que fique 0 se não foi medido

            RuleFor(x => x.CircunferenciaCintura)
                .GreaterThanOrEqualTo(0).WithMessage("A Cintura não pode ser negativa.");

            RuleFor(x => x.CircunferenciaQuadril)
                .GreaterThanOrEqualTo(0).WithMessage("O Quadril não pode ser negativo.");

            // Braços
            RuleFor(x => x.CircunferenciaBracoDireito)
                .GreaterThanOrEqualTo(0).WithMessage("Braço Direito inválido.");

            RuleFor(x => x.CircunferenciaBracoEsquerdo)
                .GreaterThanOrEqualTo(0).WithMessage("Braço Esquerdo inválido.");

            // Coxas
            RuleFor(x => x.CircunferenciaCoxaDireita)
                .GreaterThanOrEqualTo(0).WithMessage("Coxa Direita inválida.");

            RuleFor(x => x.CircunferenciaCoxaEsquerda)
                .GreaterThanOrEqualTo(0).WithMessage("Coxa Esquerda inválida.");

            // Panturrilhas
            RuleFor(x => x.CircunferenciaPanturrilhaDireita)
                .GreaterThanOrEqualTo(0).WithMessage("Panturrilha Direita inválida.");

            RuleFor(x => x.CircunferenciaPanturrilhaEsquerda)
                .GreaterThanOrEqualTo(0).WithMessage("Panturrilha Esquerda inválida.");
        }
    }
}