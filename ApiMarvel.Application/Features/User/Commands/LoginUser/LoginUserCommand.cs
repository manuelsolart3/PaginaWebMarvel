using ApiMarvel.Application.Abstractions.Messaging;

namespace ApiMarvel.Application.Features.User.Commands.LoginUser;

public record LoginUserCommand(string Email, string Identification) : ICommand<string>;
