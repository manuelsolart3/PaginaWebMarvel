using ApiMarvel.Application.Abstractions.Messaging;

namespace ApiMarvel.Application.Features.User.Commands.RemoveFavoriteComic;

public record RemoveFavoriteComicCommand(Guid Id) : ICommand;

