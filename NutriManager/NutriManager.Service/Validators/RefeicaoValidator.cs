using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class RefeicaoValidator : AbstractValidator<Refeicao>
    {
        public RefeicaoValidator()
        {

            RuleFor(c => c.Nome).NotEmpty().WithMessage("O nome da refeição é obrigatório.");
            RuleFor(c => c.HorarioSugestao).NotEmpty();
        }
    }
}