using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class PlanoAlimentarValidator : AbstractValidator<PlanoAlimentar>
    {
        public PlanoAlimentarValidator()
        {
            RuleFor(p => p.DescricaoGeral)
                .NotEmpty().WithMessage("Informe a descrição.")
                .MaximumLength(45);

            RuleFor(p => p.DataInicio)
                .NotNull().WithMessage("Informe a data de início.");

            RuleFor(p => p.DataFim)
                .NotNull().WithMessage("Informe a data de fim.")
                .GreaterThanOrEqualTo(p => p.DataInicio).WithMessage("Data de fim deve ser maior ou igual à data de início.");

            RuleFor(p => p.CaloriasDiarias)
                .GreaterThanOrEqualTo(0).WithMessage("Informe calorias diárias positivas.");

            RuleFor(p => p.RefeicoesPorDia)
                .GreaterThan(0).WithMessage("Informe quantidade de refeições por dia.");
        }
    }
}
