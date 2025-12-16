using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class BioimpedanciaValidator : AbstractValidator<Bioimpedancia>
    {
        public BioimpedanciaValidator()
        {
            RuleFor(b => b.PercentualGordura)
                .InclusiveBetween(0, 100).WithMessage("O percentual de gordura deve estar entre 0 e 100.");

            RuleFor(b => b.PercentualMassaMagra)
                .InclusiveBetween(0, 100).WithMessage("O percentual de massa magra deve estar entre 0 e 100.");

            RuleFor(b => b.PercentualAguaCorporal)
                .InclusiveBetween(0, 100).WithMessage("O percentual de água corporal deve estar entre 0 e 100.");

            RuleFor(b => b.MassaMagra)
                .GreaterThanOrEqualTo(0).WithMessage("A massa magra deve ser positiva.");

            RuleFor(b => b.MassaGorda)
                .GreaterThanOrEqualTo(0).WithMessage("A massa gorda deve ser positiva.");

            RuleFor(b => b.TaxaMetabolicaBasal)
                .GreaterThanOrEqualTo(0).WithMessage("A taxa metabólica basal deve ser positiva.");
        }
    }
}
