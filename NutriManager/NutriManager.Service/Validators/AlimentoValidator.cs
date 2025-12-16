using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class AlimentoValidator : AbstractValidator<Alimento>
    {
        public AlimentoValidator()
        {
            RuleFor(a => a.Nome)
                .NotEmpty().MaximumLength(45);

            RuleFor(a => a.Porcao)
                .NotEmpty().MaximumLength(45);

            RuleFor(a => a.Calorias)
                .GreaterThanOrEqualTo(0);

            RuleFor(a => a.Proteinas)
                .GreaterThanOrEqualTo(0);

            RuleFor(a => a.Carboidratos)
                .GreaterThanOrEqualTo(0);

            RuleFor(a => a.Gorduras)
                .GreaterThanOrEqualTo(0);
        }
    }
}
