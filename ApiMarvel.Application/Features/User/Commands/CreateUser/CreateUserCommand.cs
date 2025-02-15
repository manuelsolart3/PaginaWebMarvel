using ApiMarvel.Application.Abstractions.Messaging;

namespace ApiMarvel.Application.Features.User.Commands.CreateUser;

public record CreateUserCommand(
   string FullName,
   string Identification,
   string Email) : ICommand;
