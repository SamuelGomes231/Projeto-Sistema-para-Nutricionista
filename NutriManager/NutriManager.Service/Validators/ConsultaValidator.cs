using FluentValidation;
using NutriManager.Domain.Entities;

namespace NutriManager.Service.Validators
{
    public class ConsultaValidator : AbstractValidator<Consulta>
    {
        public ConsultaValidator()
        {
            RuleFor(c => c.DataConsulta)
                .NotNull();

            RuleFor(c => c.Objetivo)
                .NotEmpty().MaximumLength(45);

            RuleFor(c => c.Observacoes)
                .MaximumLength(45);

            RuleFor(c => c.ObservacoesGerais)
                .MaximumLength(45);

            RuleFor(c => c.DataConsulta)
                .NotEmpty().WithMessage("A data da consulta é obrigatória.");

            RuleFor(c => c.Paciente)
                .NotNull().WithMessage("Selecione um paciente.");

            RuleFor(c => c.Objetivo)
                .NotEmpty().WithMessage("Informe o objetivo da consulta.");

        }
    }
}
