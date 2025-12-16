using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class RefeicaoAlimentoValidator : AbstractValidator<RefeicaoAlimento>
    {
        public RefeicaoAlimentoValidator()
        {
            RuleFor(c => c.AlimentoId).GreaterThan(0).WithMessage("Selecione um alimento.");
        }
    }
}