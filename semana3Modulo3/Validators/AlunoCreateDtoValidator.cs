using FluentValidation;
using LabSchool.Dtos;

namespace LabSchool.Validators;

public class AlunoCreateDtoValidator : AbstractValidator<AlunoCreateDto>
{
    public AlunoCreateDtoValidator()
    {
        RuleFor(dto => dto.Nome)
            .NotEmpty()
            .NotNull()
            .Length(8, 50)
            .WithMessage("Nome não pode ser nulo");
        RuleFor(dto => dto.Nome).Length(8, 50).WithMessage("Nome deve ter entre 8 e 50 caracteres");
        RuleFor(dto => dto.DataDeNascimento)
            .NotEmpty()
            .NotNull()
            .LessThan(DateTime.Now)
            .WithMessage("A data deve ser inferior à atual");
        RuleFor(dto => dto.CPF).Length(11).WithMessage("CPF deve ter 11 números");
        RuleFor(dto => dto.Nota)
            .LessThanOrEqualTo(10)
            .GreaterThanOrEqualTo(0)
            .WithMessage("A nota informada deve ser entre 0 & 10");
    }
}
