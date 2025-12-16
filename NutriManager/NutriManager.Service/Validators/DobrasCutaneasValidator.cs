using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class DobrasCutaneasValidator : AbstractValidator<DobrasCutaneas>
    {
        public DobrasCutaneasValidator()
        {
            RuleFor(d => d.DobraTricipital)
                .GreaterThanOrEqualTo(0);

            RuleFor(d => d.DobraSubescapular)
                .GreaterThanOrEqualTo(0);

            RuleFor(d => d.DobraSuprailiaca)
                .GreaterThanOrEqualTo(0);

            RuleFor(d => d.DobraAbdominal)
                .GreaterThanOrEqualTo(0);

            RuleFor(d => d.DobraCoxa)
                .GreaterThanOrEqualTo(0);
        }
    }
}
