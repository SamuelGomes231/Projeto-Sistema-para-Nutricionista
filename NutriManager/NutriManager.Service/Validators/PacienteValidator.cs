using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class PacienteValidator : AbstractValidator<Paciente>
    {
        public PacienteValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("Informe o nome.")
                .MaximumLength(45);

            RuleFor(p => p.Sexo)
                .NotEmpty().WithMessage("Informe o sexo.")
                .MaximumLength(45);

            RuleFor(p => p.Telefone)
                .NotEmpty().WithMessage("Informe o telefone.")
                .MaximumLength(45);

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Informe o email.")
                .MaximumLength(45)
                .EmailAddress().WithMessage("Email inválido.");

            RuleFor(p => p.DataNascimento)
                .NotNull().WithMessage("Informe a data de nascimento.");
        }
    }
}
