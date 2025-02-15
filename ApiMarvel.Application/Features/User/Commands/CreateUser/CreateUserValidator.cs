using FluentValidation;

namespace ApiMarvel.Application.Features.User.Commands.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty().WithMessage("El nombre es obligatorio")
            .MaximumLength(50).WithMessage("El nombre no puede superar los 50 caracteres");

        RuleFor(x => x.Identification)
            .NotEmpty().WithMessage("El apellido es obligatorio")
            .MaximumLength(25).WithMessage("La identificación no puede superar los 25 caracteres");
    }
}